using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusSubtractTime : MonoBehaviour
{
    // Start is called before the first frame update
    float plusTime = 5f;
    float subtractTime = -10f;
    private GameObject gm;

    public float internalTimer;

    void Start(){
        gm = GameObject.Find("GameManager");
    }

    void Update(){

        internalTimer += Time.deltaTime;

        if(internalTimer%60 >= 3){
            Destroy(gameObject);
        }
    }

    public float AddTime(){

        if(gameObject.tag == "PlusTime"){
            return plusTime;
        }else if(gameObject.tag == "SubtractTime"){
            return subtractTime;
        }else {
            return 0;
        }
    }

    void OnCollisionEnter2D(Collision2D other){

        if(other.gameObject.tag == "Player"){

            Debug.Log("Uoh, you hitted me! How rude!");

            if(gameObject.tag == "PlusTime"){

                gm.GetComponent<GameManager>().gameTimer += plusTime;
            }else if(gameObject.tag == "SubtractTime"){

                gm.GetComponent<GameManager>().gameTimer += subtractTime;
            }
        }

        Destroy(gameObject);
    }
}
