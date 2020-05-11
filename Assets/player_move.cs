using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start(){
        speed=5.0f;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey("q") && gameObject.transform.position.x > 0)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("d") && gameObject.transform.position.x < 12)
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