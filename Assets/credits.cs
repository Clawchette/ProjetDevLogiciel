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
        creditscount = 0;
        gameObject.GetComponent<TextMeshProUGUI>().text = "Crédit : 0";
    }

    
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = "Crédits : " + creditscount;
    }
}
