﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemypatrol : MonoBehaviour
{
    public GameObject leftBorder;
    public GameObject rightBorder;
    public bool isRideDirection;
    public float speed;
    public Rigidbody2D rigidbody;
    public GroundDetection groundDetection;

    private void Start()
    {
        groundDetection = GetComponent<GroundDetection>();
    }
    private void Update()
    {
        if (isRideDirection && groundDetection.isGraund)
        {
            rigidbody.AddForce(Vector2.right  * speed, ForceMode2D.Impulse);
            if (transform.position.x > rightBorder.transform.position.x)
            {
                int V = 0;
                rigidbody.velocity = Vector2.left * V;
                isRideDirection = false;
            }
        }
        else if (groundDetection.isGraund)
        {
            rigidbody.AddForce(Vector2.left  * speed, ForceMode2D.Impulse);
            if (transform.position.x < leftBorder.transform.position.x)
            {
                int V = 0;
                rigidbody.velocity = Vector2.right * V;
                isRideDirection = true;
            }
        }
    }

}
