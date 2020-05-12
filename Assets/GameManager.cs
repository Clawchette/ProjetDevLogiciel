using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

        //Variables par défaut / à sauvegarder
    public int credits;
    //modifiables UNIQUEMENT dans le menu équipement
    //Si elles sont modifiées à la fin d'un niveau par les buffs obtenus dans la partie ça pète la sauvegarde 
    //donc faut faire attention stplz
    public float vitesseDefilement;
    public float vitesseDeplacement;
    public float vitesseTir;

    void Start()
    {

        credits = 0;
        vitesseDefilement = 1f;
        vitesseDeplacement = 5f;
        vitesseTir = 0.5f;
    }

    public void DefilementAugm(){
        if(vitesseDefilement>0.5f){
            vitesseDefilement-=0.1f;
        }        
    }
}
