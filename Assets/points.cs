﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class points : MonoBehaviour
{
    private int credit_fin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        credit_fin = GameObject.Find("gameManager").GetComponent<GameManager>().credits;
        gameObject.GetComponent<TextMeshProUGUI>().text = "Crédits :" + credit_fin;
    }
}
