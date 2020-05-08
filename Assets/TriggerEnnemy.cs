using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnnemy : MonoBehaviour
{
    public bool isGameOver;

    void Start()
    {
        isGameOver= false;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag=="Ennemy"){
            isGameOver=true;
        } 
    }
}
