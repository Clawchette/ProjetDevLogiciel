using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnnemy : MonoBehaviour
{

    private void OnTriggerEnter(Collider other){
        if(other.tag=="Ennemy"){
            GameObject.Find("gameManager").GetComponent<GameManager>().didPlayerDie=true;
        } 
    }
}
