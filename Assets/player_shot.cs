using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shot : MonoBehaviour
{
    public GameObject myPrefabObject;
    private GameManager gameManager;
    private float fireRate;
    private float nextFire;

    void Start(){
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
        //vitesse de tir (change au cours de la partie si récup de buff, change en dehors de la partie avec le menu équipement)
        fireRate = gameManager.vitesseTir;
        nextFire=0f;
    }

    void Update()
    { 
        //le joueur tire s'il appuie sur ESPACE, que le jeu est actif et que le timer le lui permet
        if (Input.GetKeyDown("space") && Time.time > nextFire && gameManager.isGameActive==true)
        {
            nextFire = Time.time + fireRate;
            //fait apparaitre la munition
            Instantiate(myPrefabObject,new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+2, gameObject.transform.position.z),Quaternion.identity);
        }
    }

    //change la vitesse de tir du joueur si il récupère un buff de tir
    public void VitTirDimin(){
        if(fireRate>0f){
            fireRate-=0.1f;
        }       
    }
}
