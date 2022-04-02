using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameUIController : MonoBehaviour
{
    public GameManager gm;
    public Player player;
    public GameObject menuLayer;

    void Start(){

        menuLayer.SetActive(false);
    }

    public void OnMenuClick(){

        Debug.Log("Menu button clicked");

        menuLayer.SetActive(true);
        gm.StopGame();
        player.StopGame();
    }

    public void OnStartMenuClick(){
        Debug.Log("You will return to the star menu");

        SceneManager.LoadScene("StartMenu");
    }

    public void OnResumeClick(){
        Debug.Log("You will resume your current game");

        menuLayer.SetActive(false);
        gm.ResumeGame();
        player.ResumeGame();
    }
}
