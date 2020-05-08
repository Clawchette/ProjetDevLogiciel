using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //pour le spawn des ennemis
    public GameObject DefilementAugm;       //ennemi qui augmente la vitesse de défilement
    public GameObject DeplacementAugm;      //ennemi qui augmente la vitesse de déplacement
    public GameObject VitTirDimin;          //ennemi qui diminue la vitesse de tir
    public GameObject Neutre;               //ennemi sans effet special
    private Vector3 position;
    private int randomPos;
    public int spawnSpeed;                  //un nouvel ennemi spawn toutes les x secondes
    private float timer;

    //pour la fin du jeu
    private GameObject player;
    private GameObject ground;

    void Start()
    {
        spawnSpeed=3;

        player = GameObject.FindWithTag("Player");
        ground = GameObject.FindWithTag("Ground");
    }

    void Update()
    {
        //Spawn Ennemis
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            randomPos = Random.Range(0, 5)*3;           //renvoie 0, 3, 6, 9 ou 12 aléatoirement, soit les positions x possibles
            position = new Vector3(randomPos, 30, 0);
            SpawnEnnemy(position);
            timer = spawnSpeed;
        }

        //Verif si la partie est finie
        if(player.GetComponent<TriggerEnnemy>().isGameOver==true || ground.GetComponent<TriggerEnnemy>().isGameOver==true){
            Debug.Log("Fin de la partie"); //a remplacer par changement vers ecran de fin de partie
        }
    }


    private void SpawnEnnemy(Vector3 position){
        int random = Random.Range(1, 100);         //proba de spawn des types d'ennemis
        if (1 <= random && random < 55)            //55% - Ennemi neutre  
        {
            Instantiate(Neutre, position, gameObject.transform.rotation);
        }
        else if(55 <= random && random < 70){      //15% - Ennemi qui aumente la vitesse de defilement
            Instantiate(DefilementAugm, position, gameObject.transform.rotation);
        }
        else if(70 <= random && random < 85){      //15% - Ennemi qui augmente la vitesse de deplacement
            Instantiate(DeplacementAugm, position, gameObject.transform.rotation);
        }
        else if(85 <= random && random < 100){     //15% - Ennemi qui diminue la vitesse de tir
            Instantiate(VitTirDimin, position, gameObject.transform.rotation);
        }
    }

}
