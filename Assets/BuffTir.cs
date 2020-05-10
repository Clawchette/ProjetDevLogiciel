using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffTir : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            other.GetComponent<player_shot>().VitTirDimin();
            Destroy(gameObject);
        }
    }
}
