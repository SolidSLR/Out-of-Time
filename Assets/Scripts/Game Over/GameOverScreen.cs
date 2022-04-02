using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void OnReplayClick(){

        Debug.Log("You will play again");

        SceneManager.LoadScene("Game");
    }

    public void OnStartMenuClick(){

        Debug.Log("You will go to the start menu");

        SceneManager.LoadScene("StartMenu");
    }
}
