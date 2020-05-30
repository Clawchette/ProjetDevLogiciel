using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleGameManager : MonoBehaviour
{
    static SingleGameManager instance;

    //s'il y a déjà un gameManager, il est détruit. 
    void Awake(){
        if(instance != null){
            Destroy(gameObject);
        }
        //Sinon, la fonction "DontDestroyOnLoad" lui est appliquée, lui permettant de rester d'une scène à l'autre
        else{
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
