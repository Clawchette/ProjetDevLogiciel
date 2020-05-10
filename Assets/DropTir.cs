using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTir : MonoBehaviour
{
    public GameObject BuffVitTirDimin;
    
    private void OnTriggerEnter(Collider other){
        if(other.tag=="Bullet"){
            Instantiate(BuffVitTirDimin,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
