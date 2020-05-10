using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDefilement : MonoBehaviour
{
    public GameObject BuffDefilementAugm;
    
    private void OnTriggerEnter(Collider other){
        if(other.tag=="Bullet"){
            Instantiate(BuffDefilementAugm,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
