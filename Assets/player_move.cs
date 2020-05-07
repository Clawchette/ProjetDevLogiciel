using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float speed = 10.0f;
    public float time = 10.0f;
    private float x = 6.0f;
    private float y = 1.5f;
    private float z = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown("d") && x != 12)
        {
            x += 3;
            transform.position = new Vector3(x, y, z);
        }
        if (Input.GetKeyDown("q") && x != 0)
        {
            x -= 3;
            transform.position = new Vector3(x,y,z);
        }
    }
}