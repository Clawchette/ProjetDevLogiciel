using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffTir : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            //diminue la vitesse de tir quand le joueur touche la sphere de buff qui est ensuite détruite
            other.GetComponent<player_shot>().VitTirDimin();
            Destroy(gameObject);
        }
    }
}
