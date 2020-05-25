using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

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
        isGameActive = true;        //il faudra qu'il soit en false par défaut et que le bouton start du menu principal le mette en true
        didPlayerDie = false; 
>>>>>>> 19aa3a88c3a72ab606ba08bf3280a32f91964761

        credits = 0;
        vitesseDefilement = 1f;
        vitesseDeplacement = 5f;
        vitesseTir = 0.5f;

        vitesseDefilementBuff=vitesseDefilement;
    }

    public void DefilementAugm(){
        if(vitesseDefilementBuff>0.5f){
            vitesseDefilementBuff-=0.1f;
        }        
    }
}
