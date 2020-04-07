using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public int damage = 10;
    public string collisionTag;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == collisionTag)
        {
            Debug.Log("с правильным");
        }
        else
        {
            Debug.Log("с неправильным");
        }
        
    }
}
