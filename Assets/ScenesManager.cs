using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void StartGame(){
        gameObject.GetComponent<Save>().LoadGame();
        SceneManager.LoadScene("SampleScene");
    }

    public void RetourMenuPrincipal(){
        GameObject.Find("gameManager").GetComponent<GameManager>().credits=GameObject.Find("CreditsCount").GetComponent<credits>().creditscount;
        gameObject.GetComponent<Save>().SaveGame();
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
