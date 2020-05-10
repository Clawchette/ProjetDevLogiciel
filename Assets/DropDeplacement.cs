using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDeplacement : MonoBehaviour
{
    public GameObject BuffDeplacementAugm;
    
    private void OnTriggerEnter(Collider other){
        if(other.tag=="Bullet"){
            Instantiate(BuffDeplacementAugm,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
