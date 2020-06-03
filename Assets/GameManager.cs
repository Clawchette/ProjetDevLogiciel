using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //pour la fin du jeu
    public bool isGameActive;
    public bool didPlayerDie;

    // pour le score en scene lose
    public int score;

    //Variables par défaut / à sauvegarder et à charger
    public int credits;
        //les variables suivantes sont modifiables UNIQUEMENT dans le menu équipement pour la sauvegarde
    public float vitesseDefilement;
    public float vitesseDeplacement;
    public float vitesseTir;

    //pour les buffs en partie, pas modifiée avec le menu équipement et non sauvegardée 
    public float vitesseDefilementBuff;

    void Start()
    {
        //par défaut, la partie est inactive (puisque le joueur est d'abord dans le menu principal)
        isGameActive = false;        
        //par défaut, le joueur n'est pas marqué comme étant mort
        didPlayerDie = false; 

        //les variables par défaut. S'il y a un fichier de sauvegarde, elles seront écrasées par les valeurs sauvegardées
        credits = 0;
        vitesseDefilement = 1f;
        vitesseDeplacement = 5f;
        vitesseTir = 0.5f;
        score = 0;

        //variable de vitesse de défilement pour la partie
        //cette variable est dans le gameManager pour qu'elle affecte la vitesse de défilement de tous les ennemis à tout moment
        vitesseDefilementBuff=vitesseDefilement;
    }

    void Update()
    {
        //Si le joueur est mort...
        if(didPlayerDie==true){
            //... le jeu devient inactif et la scène change vers celle de fin de jeu (perdu)...
            isGameActive=false;
            SceneManager.LoadScene("lose");
            //... puis le joueur est à nouveau remis comme vivant (remise à 0 pour la partie suivante)
            didPlayerDie = false;
        }   

    }

    //Si le joueur quitte le jeu...
    public void PlayerQuit(){
        if(GameObject.Find("CreditsCount")){
            //... les crédits qu'il a gagné au cours de la partie sont ajoutés à ses crédits totaux...
            credits=GameObject.Find("CreditsCount").GetComponent<credits>().creditscount;
        }
        //... la partie est sauvegardée...
        gameObject.GetComponent<Save>().SaveGame();
        //... le jeu devient inactif...
        isGameActive=false;
        //... la scène change vers celle de fin de jeu (pas perdu)
        SceneManager.LoadScene("player_quit");
    }

    //ferme le jeu complètement
    public void CloseGame(){
        Application.Quit();
    }

    //change la vitesse de défilement des ennemis si le joueur récupère un buff de défilement
    public void DefilementAugm(){
        if(vitesseDefilementBuff>0.5f){
            vitesseDefilementBuff-=0.1f;
        }        
    }

    //pour le menu équipement
    //si *modif* est égal à 1, la vitesse augmente. si *modif* est égal à -1, la vitesse baisse.
    public void EquipDefil(int modif){
        //modifie la vitesse de défilement de façon positive ou négative
        vitesseDefilement+=modif*0.1f;
        Payer();
    }
    public void EquipDepl(int modif){
        //modifie la vitesse de déplacement de façon positive ou négative
        vitesseDeplacement+=modif*2;
        Payer();
    }
    public void EquipTir(int modif){
        //modifie la vitesse de tir de façon positive ou négative
        vitesseTir-=modif*0.1f;
        Payer();
    }
    public void Payer(){
        //met à jour le nombre de crédits du joueur
        //dans le gameManager (variable sauvegardée et constant d'une scène à l'autre) :
        credits-=10;
        //dans l'affichage du nombre de crédits dans le menu équipement et dans la partie :
        GameObject.Find("CreditsCount").GetComponent<credits>().creditscount-=10;
    }

}
