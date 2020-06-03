using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    //charge la dernière sauvegarde et change la scène vers celle de jeu
    public void StartGame(){
        gameObject.GetComponent<Save>().LoadGame();
        SceneManager.LoadScene("SampleScene");
    }

    //si le joueur retourne au menu principal à partir du jeu, ses crédits gagnés sont sauvegardés et la scène change vers celle du menu principal 
    public void RetourMenuPrincipal(){
        if(GameObject.Find("CreditsCount")){
            GameObject.Find("gameManager").GetComponent<GameManager>().credits=GameObject.Find("CreditsCount").GetComponent<credits>().creditscount;
        }
        gameObject.GetComponent<Save>().SaveGame();
        SceneManager.LoadScene("menue_scene");
    }

    //mchange la scène vers celle du menu about
    public void MenuAbout(){
        SceneManager.LoadScene("About");
    }

    //charge la dernière partie sauvegardée et change la scène vers celle du menu équipement
    public void MenuAmeliorations(){
        gameObject.GetComponent<Save>().LoadGame();
        SceneManager.LoadScene("amelioration");
    }

    public void QuitterJeu(){
        
    }

}
