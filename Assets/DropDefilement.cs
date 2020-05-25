using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDefilement : MonoBehaviour
{
    public GameObject BuffDefilementAugm;
    private GameObject clone;

    private void OnTriggerEnter(Collider other){
        if(other.tag=="Bullet"){
            clone = Instantiate(BuffDefilementAugm,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(clone,5);
            Destroy(gameObject);
        }
    }
}
