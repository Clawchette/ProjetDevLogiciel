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
        //Si elles sont modifiées à la fin d'un niveau par les buffs obtenus dans la partie ça pète la sauvegarde 
        //donc faut faire attention stplz
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

    public void PlayerQuit(){   //à associer à un bouton sur le menu de pause
        //le joueur quitte la partie
        gameObject.GetComponent<Save>().SaveGame();
        isGameActive=false;
        SceneManager.LoadScene("menue_scene"); //a remplacer par changement vers ecran de fin de partie avec infos sur la partie
    }

    public void RetourMenu(){       //une fonction à mettre sur un bouton sur l'écran pour pas qu'elle soit lancée par accident
        SceneManager.LoadScene("menue_scene");
    }

    public void CloseGame(){
        Application.Quit();
    }

    public void DefilementAugm(){
        if(vitesseDefilementBuff>0.5f){
            vitesseDefilementBuff-=0.1f;
        }        
    }

    public void StartGame(){
        gameObject.GetComponent<Save>().LoadGame();
        SceneManager.LoadScene("SampleScene");
        isGameActive=true;
    }
}
