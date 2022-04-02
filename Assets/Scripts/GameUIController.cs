using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUIController : MonoBehaviour
{
    public GameManager gm;
    public Player player;

    public void OnMenuClick(){

        Debug.Log("Menu button clicked");

        player.StopGame();
        gm.StopGame();
    }
}
