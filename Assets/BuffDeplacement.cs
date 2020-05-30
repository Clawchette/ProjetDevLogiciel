using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffDeplacement : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            //augmente la vitesse de déplacement quand le joueur touche la sphere de buff qui est ensuite détruite
            other.GetComponent<player_move>().DeplacementAugm();
            Destroy(gameObject);
        }
    }
}
