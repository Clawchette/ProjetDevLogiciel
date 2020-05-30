using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class points : MonoBehaviour
{
    private int credit_fin;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
    }

    //affiche les crédits que le joueur possède quand il perd
    void Update()
    {
        credit_fin = gameManager.credits;
        gameObject.GetComponent<TextMeshProUGUI>().text = "Crédits :" + credit_fin;
    }
}
