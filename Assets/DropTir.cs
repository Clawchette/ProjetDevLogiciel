using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTir : MonoBehaviour
{
    public GameObject BuffVitTirDimin;
    private GameObject clone;

    private void OnTriggerEnter(Collider other){
        if(other.tag=="Bullet"){
            clone = Instantiate(BuffVitTirDimin,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(clone,5);
            Destroy(gameObject);
        }
    }
}
