using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDeplacement : MonoBehaviour
{
    public GameObject BuffDeplacementAugm;
    private GameObject clone;

    private void OnTriggerEnter(Collider other){
        if(other.tag=="Bullet"){
            clone = Instantiate(BuffDeplacementAugm,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(clone,5);
            Destroy(gameObject);
        }
    }
}
