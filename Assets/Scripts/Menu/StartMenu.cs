using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class StartMenu : MonoBehaviour
{
    public GameObject infoScreen;
    private AudioSource audioSource;

    void Awake(){

        audioSource = GetComponent<AudioSource>();
        infoScreen.SetActive(false);
    }
    public void OnPlayGameClick(){

        Debug.Log("You will play the game");

        audioSource.Play();
        SceneManager.LoadScene("Game"); 
    }

    public void OnGameInfoClick(){

        audioSource.Play();
        infoScreen.SetActive(true);

        Debug.Log("I will show you some info");
    }

    public void OnExitInfoClick(){

        audioSource.Play();
        infoScreen.SetActive(false);
    }

    public void OnExitGameClick(){

        audioSource.Play();
        Application.Quit();
    }
}
