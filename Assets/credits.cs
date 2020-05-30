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
        //récupère les crédits que le joueur possède déjà
        creditscount = GameObject.Find("gameManager").GetComponent<GameManager>().credits;
        gameObject.GetComponent<TextMeshProUGUI>().text = "Crédit : 0";
    }

    
    void Update()
    {
        //affiche le nombre de crédits du joueur en temps réel
        gameObject.GetComponent<TextMeshProUGUI>().text = "Crédits : " + creditscount;
    }
}
