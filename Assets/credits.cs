using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class credits : MonoBehaviour
{
    public int creditscount;

    
    void Start()
    {
        creditscount = GameObject.Find("gameManager").GetComponent<GameManager>().credits;
        gameObject.GetComponent<TextMeshProUGUI>().text = "Crédit : 0";
    }

    
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = "Crédits : " + creditscount;
    }
}
