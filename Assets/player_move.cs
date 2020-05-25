using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    private GameManager gameManager;
    private float speed;

    // Start is called before the first frame update
    void Start(){
<<<<<<< HEAD
        speed=GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDeplacement;
=======
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
        speed=gameManager.vitesseDeplacement;
>>>>>>> b73b15ee44c6db1876c3ee8aed521f8f0786c552
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