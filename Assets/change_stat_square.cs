﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_stat_square : MonoBehaviour
{

    public void MonterDeplacement()
    {
        
        if(GameObject.Find("gameManager").GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().EquipDepl(1);
        }
    }
    public void BaisserDeplacement()
    {
        if(GameObject.Find("gameManager").GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().EquipDepl(-1);
        }
    }
    public void BaisserDefilement()
    {
        if(GameObject.Find("gameManager").GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().EquipDefil(-1);
        }
    }
    public void MonterDefilement()
    {
        if(GameObject.Find("gameManager").GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().EquipDefil(-1);
        }
    }
    public void BaisserTir()
    {
        if(GameObject.Find("gameManager").GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().EquipTir(-1);
        }
    }
    public void MonterTir()
    {
        if(GameObject.Find("gameManager").GetComponent<GameManager>().credits>=10){
            GameObject.Find("gameManager").GetComponent<GameManager>().EquipTir(1);
        }
    }
    
}
