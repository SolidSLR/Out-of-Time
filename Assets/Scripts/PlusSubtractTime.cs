using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusSubtractTime : MonoBehaviour
{
    // Start is called before the first frame update
    float plusTime = 5f;
    float subtractTime = -10f;

    public float AddTime(){

        if(gameObject.tag == "PlusTime"){
            return plusTime;
        }else if(gameObject.tag == "SubtractTime"){
            return subtractTime;
        }else {
            return 0;
        }
    }
}
