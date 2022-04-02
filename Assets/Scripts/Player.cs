using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed = 5f;
    public GameManager gm;
    // Create the player timer

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.W)){

            rb.velocity = Vector2.up * speed;
        } else if(Input.GetKey(KeyCode.S)){

            rb.velocity = Vector2.down * speed;
        }else if(Input.GetKey(KeyCode.D)){
            
            rb.velocity = Vector2.right * speed;
        }else if(Input.GetKey(KeyCode.A)){

            rb.velocity = Vector2.left * speed;
        }else{

            rb.velocity = new Vector2(0,0);

            
        }
    }
}
