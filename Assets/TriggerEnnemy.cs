using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnnemy : MonoBehaviour
{

    private void OnTriggerEnter(Collider other){
        //s'il y a contact avec un cube ennemi, change une variable du gameManager qui met fin au jeu
        //ce script est mis sur le sol et sur le joueur
        if(other.tag=="Ennemy"){
            GameObject.Find("gameManager").GetComponent<GameManager>().didPlayerDie=true;
        } 
    }
}
