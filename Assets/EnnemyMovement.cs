using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMovement : MonoBehaviour
{
    private float x;
    private float y;
    private float timer;
    public float vitesse;       //le nombre de secondes entre chaque mouvement de l'ennemi

    private GameManager gameManager;

    void Start()
    {
        gameManager=GameObject.Find("gameManager").GetComponent<GameManager>();

        x=gameObject.transform.position.x;
        y=gameObject.transform.position.y;
        timer=0.0f;
        //vitesse de défilement (change au cours de la partie si récup de buff, change en dehors de la partie avec le menu équipement)
        vitesse=gameManager.vitesseDefilement; 
    }

    void Update()
    {
        //les cubes ne bougent pas si le jeu n'est pas actif (en dehors de l'écran de jeu ou en pause par ex)
        if(gameManager.isGameActive==true){
            //change au cours de la partie si le joueur récup un buff
            vitesse = gameManager.vitesseDefilementBuff;
            //timer
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                //le cube descend d'une unité sur l'axe y toutes les *vitesse* secondes
                y--;
                gameObject.transform.position = new Vector3(x, y, 0f);
                timer = vitesse;
            }
        }
    } 

}
