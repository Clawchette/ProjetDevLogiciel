using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class credits : MonoBehaviour
{
    private TextMeshProUGUI credit_count;
    public int creditscount;

    
    void Start()
    {
        creditscount = 0;
        credit_count.text = "Crédit : 0";
    }

    
    void Update()
    {
        if(credit_count==null){
            credit_count = GameObject.Find("CreditsCount").GetComponent<TextMeshProUGUI>();
        }
        credit_count.text = "Crédits : " + creditscount;
    }
}
