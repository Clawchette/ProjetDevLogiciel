using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    private int score_fin;
    private int credit_fin;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
    }

    //affiche le score du joueur de la partie quand il quitte le jeu
    void Update()
    {
        score_fin = gameManager.score;
        gameObject.GetComponent<TextMeshProUGUI>().text = "Score :" + score_fin;
    }
}
