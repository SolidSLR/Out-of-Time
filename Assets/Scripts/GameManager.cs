using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject plusTime;

    public GameObject subtractTime;

    // Create the game timer

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpwanCorout");
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
