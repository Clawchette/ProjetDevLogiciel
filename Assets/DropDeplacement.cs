using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDeplacement : MonoBehaviour
{
    public GameObject BuffDeplacementAugm;
    private GameObject clone;

    private void OnTriggerEnter(Collider other){
        if(other.tag=="Bullet"){
            //si la munition touche un cube de buff de déplacement, spawn la sphere de buff
            clone = Instantiate(BuffDeplacementAugm,gameObject.transform.position,gameObject.transform.rotation);
            //la sphere de buff sera détruite une fois qu'elle est en dehors de l'écran si elle n'est pas touchée par le joueur
            Destroy(clone,5);
            //détruit le cube
            Destroy(gameObject);
        }
    }
}
