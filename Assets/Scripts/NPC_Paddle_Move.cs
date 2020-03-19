﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Paddle_Move : MonoBehaviour {
    // Start is called before the first frame update
    private bool dirRight = true;
    public float speed = 2.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 4.40f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -4.4f)
        {
            dirRight = true;
        }
    }
}
