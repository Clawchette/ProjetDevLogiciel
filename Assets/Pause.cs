using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private GameObject pauseCanvas;
    private GameManager gameManager;

    void Start(){
        pauseCanvas = GameObject.Find("PauseCanvas");
        pauseCanvas.SetActive(false);
        gameManager=GameObject.Find("gameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        
        if(Input.GetKeyDown("p") && gameManager.isGameActive==true){
            pauseCanvas.SetActive(true);
            gameManager.isGameActive=false;
        }
        else if(Input.GetKeyDown("p") && gameManager.isGameActive==false){
            Unpause();
        }
    }

    public void Unpause(){
        gameManager.isGameActive=true;
        pauseCanvas.SetActive(false);
    }

}
