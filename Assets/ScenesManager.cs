using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    private GameManager gameManager;

    void Start(){
        gameManager=gameObject.GetComponent<GameManager>();
    }

    public void StartGame(){
        gameObject.GetComponent<Save>().LoadGame();
        SceneManager.LoadScene("SampleScene");
        gameManager.isGameActive=true;
    }

    public void RetourMenuPrincipal(){
        SceneManager.LoadScene("menue_scene");
    }

    public void MenuAbout(){
        SceneManager.LoadScene("About");
    }

    public void MenuAmeliorations(){
        gameObject.GetComponent<Save>().LoadGame();
        SceneManager.LoadScene("amelioration");
    }

}
