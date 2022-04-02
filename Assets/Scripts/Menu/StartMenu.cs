using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class StartMenu : MonoBehaviour
{
    public GameObject infoScreen;

    void Start(){

        infoScreen.SetActive(false);
    }
    public void OnPlayGameClick(){

        Debug.Log("You will play the game");

        SceneManager.LoadScene("Game"); 
    }

    public void OnGameInfoClick(){

        infoScreen.SetActive(true);

        Debug.Log("I will show you some info");
    }

    public void OnExitInfoClick(){

        infoScreen.SetActive(false);
    }

    public void OnExitGameClick(){

        Application.Quit();
    }
}
