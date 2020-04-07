using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float speedup;
    public Rigidbody2D rigidbody;
    public float minimalHeight;
    public bool isCheatMode;
    public SpriteRenderer[] renderers;
    public GroundDetection GroundDetection;


   
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space) && GroundDetection.isGraund)
        {
            rigidbody.AddForce(Vector2.up * speedup, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.W) && GroundDetection.isGraund)
        {
            rigidbody.AddForce(Vector2.up * speedup, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rigidbody.AddForce(Vector2.down * speedup, ForceMode2D.Impulse);
        }
        if (transform.position.y < minimalHeight && isCheatMode)  //обсуждаем выход игрока за пределы игрового мира
        {
            rigidbody.velocity = new Vector2(10, 0);
            transform.position = new Vector3(-3, 1, 0);
        }
        else if (transform.position.y < minimalHeight)
            Destroy(gameObject);

    }
}
