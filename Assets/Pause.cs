using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private GameObject pauseCanvas;

    void Start(){
        pauseCanvas = GameObject.Find("PauseCanvas");
        pauseCanvas.SetActive(false);
    }

    void Update()
    {
        
        if(Input.GetKeyDown("p") && gameObject.GetComponent<GameManager>().isGameActive==true){
            pauseCanvas.SetActive(true);
            gameObject.GetComponent<GameManager>().isGameActive=false;
        }
        else if(Input.GetKeyDown("p") && gameObject.GetComponent<GameManager>().isGameActive==false){
            Unpause();
        }
    }

    public void Unpause(){
        gameObject.GetComponent<GameManager>().isGameActive=true;
        pauseCanvas.SetActive(false);
    }
}
