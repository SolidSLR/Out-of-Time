using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Reference to the player. Will be used to modify its speed.
    public GameObject player;
    public GameObject plusTime;
    public GameObject subtractTime;
    public float gameTimer;
    public TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(plusTime, new Vector2(Random.Range(-6.4f, 6.4f), Random.Range(-4.8f, 3.8f)), Quaternion.identity);
        Instantiate(plusTime, new Vector2(Random.Range(-6.4f, 6.4f), Random.Range(-4.8f, 3.8f)), Quaternion.identity);
        Instantiate(subtractTime, new Vector2(Random.Range(-6.4f, 6.4f), Random.Range(-4.8f, 3.8f)), Quaternion.identity);
        StartCoroutine("SpawnCorout");
    }

    // Update is called once per frame
    void Update()
    {
        if(gameTimer>0){

            gameTimer -= Time.deltaTime;
            timeText.text = TimeCalculator(gameTimer);  
        }else if(gameTimer <=0 || player.GetComponent<Player>().playerTimer/60 >=3){

            timeText.text = "00:00";
            //Time.timeScale = 0;
            StopGame();
        }      
    }

    private void SpawnTimeModifier(){

        Vector2 randomPos = new Vector2(Random.Range(-6.4f, 6.4f), Random.Range(-4.8f, 3.8f));
        //int randomPrefab = Random.Range(0,100);
        float randomPrefab = Random.value;
        if(randomPrefab < 0.5f){
            Instantiate(plusTime, randomPos, Quaternion.identity);
        } else {
            Instantiate(subtractTime, randomPos, Quaternion.identity);
        }
    }

    private IEnumerator SpawnCorout(){

        while(gameTimer>0){

            // Randomize seconds of waiting

            float seconds = Random.Range(1f, 2.5f);

            yield return new WaitForSeconds(seconds);

            SpawnTimeModifier();
        }
    }

    private string TimeCalculator(float timer){

        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);

        return string.Format("{0:00}:{1:00}",minutes,seconds);
    }

    public void StopGame(){
        Time.timeScale = 0;
    }
}
