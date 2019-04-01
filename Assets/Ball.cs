using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inPlay;
    public Transform paddle;
    //public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        

    }

    void Update()
    {
        if (inPlay== false)
        {
            transform.position = paddle.position;
        }
        if (Input.GetButtonDown ("Jump") && !inPlay) {
            inPlay = true;
            rb.AddForce (Vector2.up * 500);
        }
    }

        void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bottom"))
        {
            Debug.Log("HIT");
            rb.velocity = Vector2.zero;
            inPlay = false;
        }
    }
}
