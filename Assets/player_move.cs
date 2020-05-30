using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    private GameManager gameManager;
    private float speed;

    void Start(){
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
        //vitesse de déplacement (change au cours de la partie si récup de buff, change en dehors de la partie avec le menu équipement)
        speed=gameManager.vitesseDeplacement;
        //"l'apparition" du joueur lance le jeu en début de partie
        gameManager.GetComponent<GameManager>().isGameActive=true;
    }

    void Update()
    {
        //le joueur se déplace vers la gauche s'il appuie sur Q et que le jeu est actif
        if (Input.GetKey("q") && gameObject.transform.position.x > 0 && gameManager.isGameActive==true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        //le joueur se déplace vers la droite s'il appuie sur D et que le jeu est actif
        if (Input.GetKey("d") && gameObject.transform.position.x < 12 && gameManager.isGameActive==true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    //change la vitesse de déplacement du joueur si il récupère un buff de déplacement
    public void DeplacementAugm(){
        if(speed<20f){
            speed+=2f;
        }     
    }
}