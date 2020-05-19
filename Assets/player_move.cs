using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    private GameManager gameManager;
    private float speed;

    // Start is called before the first frame update
    void Start(){
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
        speed=gameManager.vitesseDeplacement;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey("q") && gameObject.transform.position.x > 0 && gameManager.isGameActive==true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("d") && gameObject.transform.position.x < 12 && gameManager.isGameActive==true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    public void DeplacementAugm(){
        if(speed<20f){
            speed+=2f;
        }     
    }
}