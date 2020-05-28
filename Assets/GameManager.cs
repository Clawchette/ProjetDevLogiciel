using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //pour la fin du jeu
    private GameObject player;
    private GameObject ground;
    public bool isGameActive;
    public bool didPlayerDie;

    //Variables par défaut / à sauvegarder
    public int credits;
        //les variables suivantes sont modifiables UNIQUEMENT dans le menu équipement pour la sauvegarde
    public float vitesseDefilement;
    public float vitesseDeplacement;
    public float vitesseTir;

    //pour les buffs en partie, ne PAS modifier avec le menu équipement et ne PAS sauvegarder 
    public float vitesseDefilementBuff;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        ground = GameObject.FindWithTag("Ground");
        isGameActive = false;        
        didPlayerDie = false; 

        credits = 0;
        vitesseDefilement = 1f;
        vitesseDeplacement = 5f;
        vitesseTir = 0.5f;

        vitesseDefilementBuff=vitesseDefilement;
    }

    void Update()
    {
        //Verif si le joueur est mort
        if(didPlayerDie==true){
            isGameActive=false;
            SceneManager.LoadScene("menue_scene"); //a remplacer par changement vers ecran de fin de partie avec infos sur la partie
        }   

    }

    public void PlayerQuit(){
        gameObject.GetComponent<Save>().SaveGame();
        isGameActive=false;
        SceneManager.LoadScene("menue_scene"); //a remplacer par changement vers ecran de fin de partie avec infos sur la partie
    }

    public void CloseGame(){
        Application.Quit();
    }

    public void DefilementAugm(){
        if(vitesseDefilementBuff>0.5f){
            vitesseDefilementBuff-=0.1f;
        }        
    }

    //menu equipement
    public void EquipDefil(int modif){
        vitesseDefilement+=modif*0.1f;
        Payer();
    }
    public void EquipDepl(int modif){
        vitesseDeplacement+=modif*2;
        Payer();
    }
    public void EquipTir(int modif){
        vitesseTir+=modif*0.1f;
        Payer();
    }
    public void Payer(){
        credits-=10;
    }
    

}
