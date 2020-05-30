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
        //récupère le canvas avec le menu pause et le désactive (un objet inactif ne peut pas être récupéré par Find())
        pauseCanvas = GameObject.Find("PauseCanvas");
        pauseCanvas.SetActive(false);
        gameManager=GameObject.Find("gameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        //quand le joueur appuie sur P quand le jeu est actif, le menu pause est affiché et le jeu est mis inactif   
        if(Input.GetKeyDown("p") && gameManager.isGameActive==true){
            pauseCanvas.SetActive(true);
            gameManager.isGameActive=false;
        }
        //quand le joueur appuie sur P quand le jeu est inactif, le menu pause est masqué et le jeu est mis actif   
        else if(Input.GetKeyDown("p") && gameManager.isGameActive==false){
            Unpause();
        }
    }
    //mis dans une fonction pour être utilisé par le bouton du menu
    public void Unpause(){
        gameManager.isGameActive=true;
        pauseCanvas.SetActive(false);
    }

}
