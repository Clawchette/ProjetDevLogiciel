using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //pour la fin du jeu
    private GameObject player;
    private GameObject ground;

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
        player = GameObject.FindWithTag("Player");
        ground = GameObject.FindWithTag("Ground");

        credits = 0;
        vitesseDefilement = 1f;
        vitesseDeplacement = 5f;
        vitesseTir = 0.5f;
    }

    void Update()
    {
        //Verif si la partie est finie
        if(player.GetComponent<TriggerEnnemy>().isGameOver==true || ground.GetComponent<TriggerEnnemy>().isGameOver==true){
            Debug.Log("Fin de la partie"); //a remplacer par changement vers ecran de fin de partie
        }
    }

    public void DefilementAugm(){
        if(vitesseDefilement>0.5f){
            vitesseDefilement-=0.1f;
        }        
    }
}
