using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_animation : MonoBehaviour
{
    public float speed_bullet = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed_bullet * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag=="Ennemy"){
            if(other.name=="Neutre(Clone)"){
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
        }
        
    }
}
