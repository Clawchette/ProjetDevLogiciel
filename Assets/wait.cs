using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait : MonoBehaviour
{

    private float wait_time;

    void Start()
    {
        wait_time = 5f;
        StartCoroutine(Wait_for_intro());
    }

    //permet de changer la scène vers celle du menu principal après que l'animation d'intro soit finie
    IEnumerator Wait_for_intro()
    {
        yield return new WaitForSeconds(wait_time);

        SceneManager.LoadScene(1);

    }

}