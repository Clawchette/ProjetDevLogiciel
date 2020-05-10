using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //pour la fin du jeu
    private GameObject player;
    private GameObject ground;

    //defilement des ennemis
    public float vitesse;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        ground = GameObject.FindWithTag("Ground");

        //vitesse de defilement des ennemis
        vitesse = 1f;
    }

    void Update()
    {
        //Verif si la partie est finie
        if(player.GetComponent<TriggerEnnemy>().isGameOver==true || ground.GetComponent<TriggerEnnemy>().isGameOver==true){
            Debug.Log("Fin de la partie"); //a remplacer par changement vers ecran de fin de partie
        }
    }

    public void DefilementAugm(){
        if(vitesse>0.5f){
            vitesse-=0.1f;
        }        
    }
}
