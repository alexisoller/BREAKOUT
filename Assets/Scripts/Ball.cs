using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour{
    public AudioClip audio;
    public Text TXnumber_of_lives;
    public int lives = 3;

    private const float speedIncrement = 0.5f;
    private const float speedIncrementRate = 15.0f;
    // Use this for initialization
    void Start(){
        TXnumber_of_lives.text = lives.ToString();
        RestartBall();
        StartCoroutine(IncreaseSpeed());
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)   {

        if (collision.gameObject.tag == "Die") { 
        lives--;
        TXnumber_of_lives.text = lives.ToString();
        RestartBall();
        }
    }
    void RestartBall(){

        if (lives == 0) {
            SceneManager.LoadScene("END");
        }else {
            transform.position = new Vector3(0.0f, 0.25f, 0.0f);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().AddForce(-Random.Range(1.0f, 2.5f), 0.0f, -Random.Range(1.0f, 2.5f), ForceMode.Impulse);
        }

    }

    public void oneup() {
        lives++;
        TXnumber_of_lives.text = lives.ToString();
        AudioSource.PlayClipAtPoint(audio, this.gameObject.transform.position);
    }

    IEnumerator IncreaseSpeed()
    {
        while (true)
        {
            GetComponent<Rigidbody>().AddForce(GetComponent<Rigidbody>().velocity.normalized * speedIncrement, ForceMode.Impulse);
            yield return new WaitForSeconds(speedIncrementRate);
        }
    }
}
    




