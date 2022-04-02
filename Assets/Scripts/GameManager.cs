using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject plusTime;

    public GameObject subtractTime;

    // Create the game timer
    private float gameTimer = 3f;

    public TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpwanCorout");
    }

    // Update is called once per frame
    void Update()
    {
        if(gameTimer>0){

            gameTimer -= Time.deltaTime;

            timeText.text = TimeCalculator(gameTimer); 
            
        }else {
            Debug.Log("Run out of time");

            timeText.text = "00:00";
        }      
    }

    private void SpawnTimeModifier(){

        Vector2 randomPos = new Vector2(Random.Range(-6.4f, 6.5f), Random.Range(-5f, 5f));

        int randomPrefab = Random.Range(0,2);

        if(randomPrefab==0){

            Instantiate(plusTime, randomPos, Quaternion.identity);
        } else {
            Instantiate(subtractTime, randomPos, Quaternion.identity);
        }
    }

    private IEnumerator SpwanCorout(){

        // Modify condition to use the game and the player timers

        int j = 0;

        while(j <5){

            // Randomize seconds of waiting

            float seconds = Random.Range(1f, 2.5f);

            yield return new WaitForSeconds(seconds);        

            SpawnTimeModifier();

            j++;
        }
    }

    private string TimeCalculator(float timer){

        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);

        return string.Format("{0:00}:{1:00}",minutes,seconds);
    }
}
