using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    private int score_fin;
    private int credit_fin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score_fin = GameObject.Find("gameManager").GetComponent<GameManager>().score;
        gameObject.GetComponent<TextMeshProUGUI>().text = "Score :" + score_fin;
    }
}
