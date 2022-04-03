using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{

    public float playerTime = 60f;
    public TextMeshProUGUI playerTimeText;
    private AudioSource audioSource;

    void Start(){

        audioSource = GetComponent<AudioSource>();
        playerTime = Player.playerTimer;

        float minutes = Mathf.FloorToInt(playerTime / 60);
        float seconds = Mathf.FloorToInt(playerTime % 60);

        playerTimeText.text = "You have survived "+string.Format("{0:00}:{1:00}",minutes,seconds);

    }
    public void OnReplayClick(){

        Debug.Log("You will play again");
        audioSource.Play();
        SceneManager.LoadScene("Game");
    }

    public void OnStartMenuClick(){

        Debug.Log("You will go to the start menu");
        audioSource.Play();
        SceneManager.LoadScene("StartMenu");
    }
}
