using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    //Decrease speed as time goes by
    public float speed;
    public GameManager gm;
    // Create the player timer
    public static float playerTimer = 0;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 5f;
        audioSource = GetComponent<AudioSource>();
        ResumeGame();
    }

    // Update is called once per frame
    void Update()
    {

        playerTimer += Time.deltaTime;
        speed -= Time.deltaTime/60;

        if(playerTimer/60 >= 5){
            
            speed = 0.5f;
        }

        if(gm.gameTimer == 0){

            StopGame();
        }
        
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){

            rb.velocity = Vector2.up * speed;
        } else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){

            rb.velocity = Vector2.down * speed;
        }else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            
            rb.velocity = Vector2.right * speed;
        }else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){

            rb.velocity = Vector2.left * speed;
        }else{

            rb.velocity = new Vector2(0,0);

            
        }
    }

    void OnCollisionEnter2D(Collision2D other){

        if(other.gameObject.tag == "PlusTime" || other.gameObject.tag == "SubtractTime"){
            audioSource.Play();
        }

    }

    public void StopGame(){

        Time.timeScale = 0;
    }

    public void ResumeGame(){

        Time.timeScale = 1;
    }
}
