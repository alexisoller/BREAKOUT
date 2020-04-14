using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Paddle_Move : MonoBehaviour {
    /*
     * class to move one of the enemies, the paddle enemy
     * 
     */
    private bool dirRight = true;
    public float speed = 2.0f;

    void Start(){

    }

   
    void Update(){
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 4.40f){
            dirRight = false;
        }

        if (transform.position.x <= -4.4f)
        {
            dirRight = true;
        }
    }
}
