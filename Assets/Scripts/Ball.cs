using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * class to determinate the movement of the ball
 * 
*/
public class Ball : MonoBehaviour{
    public AudioClip audio;

    //info lives of ball
    public Text TXnumber_of_lives;
    public int lives = 3;

    //movement of the ball
    private const float speedIncrement = 0.5f;
    private const float speedIncrementRate = 15.0f;
    
    void Start(){
        TXnumber_of_lives.text = lives.ToString();
        RestartBall();
        StartCoroutine(IncreaseSpeed());
    }
    
    void Update()
    {
    }



    void OnCollisionEnter(Collision collision)   {//capture the colision to know when the ball is dead

        if (collision.gameObject.tag == "Die") { 
        lives--;
        TXnumber_of_lives.text = lives.ToString();
        RestartBall();
        }
    }


    void RestartBall(){//restart the ball on initial position

        if (lives == 0) {
            SceneManager.LoadScene("END");
        }else {
            transform.position = new Vector3(0.0f, 0.25f, 0.0f);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().AddForce(-Random.Range(1.0f, 2.5f), 0.0f, -Random.Range(1.0f, 2.5f), ForceMode.Impulse);
        }

    }

    public void oneup(){//add one life when the drop is taken
        lives++;
        TXnumber_of_lives.text = lives.ToString();
        AudioSource.PlayClipAtPoint(audio, this.gameObject.transform.position);
    }

    IEnumerator IncreaseSpeed(){
        while (true)
        {
            GetComponent<Rigidbody>().AddForce(GetComponent<Rigidbody>().velocity.normalized * speedIncrement, ForceMode.Impulse);
            yield return new WaitForSeconds(speedIncrementRate);
        }
    }
}
    




