using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_stat_square : MonoBehaviour
{
    public void MonterDeplacement()
    {
        if(gameObject.GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDeplacement --;
        }
    }
    public void BaisserDeplacement()
    {
        if(gameObject.GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDeplacement ++;
        }
    }
    public void BaisserDefilement()
    {
        if(gameObject.GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDefilement --;
        }
    }
    public void MonterDefilement()
    {
        if(gameObject.GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDefilement ++;
        }
    }
    public void BaisserTir()
    {
        if(gameObject.GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().vitesseTir --;
        }
    }
    public void MonterTir()
    {
        if(gameObject.GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().vitesseTir ++;
        }
    }
    
}
