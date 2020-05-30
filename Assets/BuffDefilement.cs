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
            //augmente la vitesse de défilement quand le joueur touche la sphere de buff qui est ensuite détruite
            gameManager.DefilementAugm();
            Destroy(gameObject);
        }
    }
}
