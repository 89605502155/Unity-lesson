using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;

    public void TakeHit(int damage)
    {
        health -= damage;
        if (health<=0)
        {
            Destroy(gameObject);
        }
    }
    public void SetHealth(int health)
    {
        this.health += health; //this необходим, чтоб увеличить основную переменную, а не ту, что внутри метода

    }
}
