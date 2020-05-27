using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_animation : MonoBehaviour
{
    public float speed_bullet = 10.0f;
    public GameObject credits;
    
    void Start()
    {
        credits=GameObject.Find("CreditsCount");
        Destroy(gameObject,5);
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed_bullet * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag=="Ennemy"){
            if(other.name=="Neutre(Clone)"){
                Destroy(other.gameObject);
            }
            credits.GetComponent<credits>().creditscount += 1;
            Destroy(gameObject);
        }
        
    }
}
