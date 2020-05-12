using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_stat_square : MonoBehaviour
{
    public void DeletSpeed()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDeplacement --;
    }
    public void UpgradeSpeed()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDeplacement ++;
    }
    public void DeletDefilement()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDefilement --;
    }
    public void UpgradeDefilement()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseDefilement ++;
    }
    public void DeletBulletSpeed()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseTir --;
    }
    public void UpgradeBulletSpeed()
    {
        GameObject.Find("gameManager").GetComponent<GameManager>().vitesseTir ++;
    }
    
}
