using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffDeplacement : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            other.GetComponent<player_move>().DeplacementAugm();
            Destroy(gameObject);
        }
    }
}
