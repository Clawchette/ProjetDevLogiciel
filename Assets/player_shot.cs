using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shot : MonoBehaviour
{
    public GameObject myPrefabObject;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

    void Update()
    { 
        if (Input.GetKeyDown("space") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(myPrefabObject,new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+2, gameObject.transform.position.z),Quaternion.identity);
        }
    }

    public void VitTirDimin(){
        if(fireRate>0f){
            fireRate-=0.1f;
        }       
    }
}
