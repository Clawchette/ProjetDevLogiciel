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
        //détruit la munition une fois qu'elle est sortie de l'écran si elle n'a pas touché de cube
        Destroy(gameObject,5);
    }

    void Update()
    {
        //envoie la munition vers le haut
        transform.Translate(Vector3.up * speed_bullet * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag=="Ennemy"){
            if(other.name=="Neutre(Clone)"){
                //détruit le cube neutre
                Destroy(other.gameObject);
                //puisque les autres cubes doivent drop un bugg avant d'être détruit, ils sont détruit dans d'autres scripts
            } 
            //ajoute un crédit/point quand un cube est détruit (total)
            credits.GetComponent<credits>().creditscount += 1;
            //ajoute un crédit/point quand un cube est détruit (partie uniquement)
            GameObject.Find("gameManager").GetComponent<GameManager>().score ++ ;
            //Détruit la munition
            Destroy(gameObject);
        }
        
    }
}
