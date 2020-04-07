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
    public int maxhealth; //задаём максимальное здоровье
    public void SetHealth(int bonushealth)
    {
        health += bonushealth; //this необходим, чтоб увеличить основную переменную, а не ту, что внутри метода
        if (health > maxhealth)
            health = maxhealth;

    }
}
