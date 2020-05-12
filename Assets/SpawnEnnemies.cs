using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnnemies : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject DefilementAugm;       //ennemi qui augmente la vitesse de défilement
    public GameObject DeplacementAugm;      //ennemi qui augmente la vitesse de déplacement
    public GameObject VitTirDimin;          //ennemi qui diminue la vitesse de tir
    public GameObject Neutre;               //ennemi sans effet special
    private Vector3 position;
    private int randomPos;
    private int spawnSpeed;                  //un nouvel ennemi spawn toutes les x secondes
    private float timer;

    void Start()
    {
        spawnSpeed=3;
        gameManager=GameObject.Find("gameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameActive==true){
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                randomPos = Random.Range(0, 5)*3;           //renvoie 0, 3, 6, 9 ou 12 aléatoirement, soit les positions x possibles
                position = new Vector3(randomPos, 30, 0);
                SpawnEnnemy(position);
                timer = spawnSpeed;
            }
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
