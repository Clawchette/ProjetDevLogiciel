using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_stat_square : MonoBehaviour
{
    public void MonterDeplacement()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDeplacement --;
    }
    public void BaisserDeplacement()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDeplacement ++;
    }
    public void BaisserDefilement()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDefilement --;
    }
    public void MonterDefilement()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDefilement ++;
    }
    public void BaisserTir()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseTir --;
    }
    public void MonterTir()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseTir ++;
    }
    
}
