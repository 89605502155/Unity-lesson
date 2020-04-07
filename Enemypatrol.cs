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

    private void Update()
    {
        if (isRideDirection)
        {
            rigidbody.AddForce(Vector2.right * Time.deltaTime * speed, ForceMode2D.Impulse);
        }
        else
        {
            rigidbody.AddForce(Vector2.left * Time.deltaTime * speed, ForceMode2D.Impulse);
        }
    }

}
