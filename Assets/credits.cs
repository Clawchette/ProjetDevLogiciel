using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class credits : MonoBehaviour
{
    public TextMeshProUGUI credit_count;
    public int compteur;
    // Start is called before the first frame update
    void Start()
    {
        compteur = 0;
        credit_count.text = "credit:" + compteur;
    }

    // Update is called once per frame
    void Update()
    {
        credit_count.text = "credit:" + compteur;
    }
}
