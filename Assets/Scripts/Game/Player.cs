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

        if(speed > 0.5f){
            speed -= Time.deltaTime/60;
        }

        if(gm.gameTimer == 0){

            StopGame();
        }
        // Commit after LD ends
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){

            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){

            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){

            transform.position += Vector3.left * speed * Time.deltaTime;
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
