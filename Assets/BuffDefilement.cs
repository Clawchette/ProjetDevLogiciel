using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffDefilement : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager=GameObject.Find("gameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other){
        if(other.tag=="Player"){
            gameManager.DefilementAugm();
            Destroy(gameObject);
        }
    }
}
