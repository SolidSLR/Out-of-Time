using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject plusTime;

    public GameObject subtractTime;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTimeModifier();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnTimeModifier(){

        Vector2 randomPos = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));

        int randomPrefab = Random.Range(0,2);

        if(randomPrefab==0){

            Instantiate(plusTime, randomPos, Quaternion.identity);
        } else {
            Instantiate(subtractTime, randomPos, Quaternion.identity);
        }
    }
}
