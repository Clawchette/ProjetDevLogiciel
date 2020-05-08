using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shot : MonoBehaviour
{
    public float vitesse ;
    private float movementSpeed;
    public GameObject myPrefabObject;
    private float timer;
    private float cooldown;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        vitesse = 1.0f;
        movementSpeed = 5f;
        cooldown = 10 ;
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown("space") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(myPrefabObject,new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+2, gameObject.transform.position.z),Quaternion.identity);
        }
    }
}
