using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float speed;
    //private float input;
    public float rightScreenEdge;
    public float leftScreenEdge;

    void Update()
    {
        //input = Input.GetAxisRaw("Horizontal");
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);
        if (transform.position.x < leftScreenEdge)
        {
            transform.position = new Vector2(leftScreenEdge, transform.position.y);
        }
        if (transform.position.x > rightScreenEdge)
        {
            transform.position = new Vector2(rightScreenEdge, transform.position.y);
        }
    }
    //private void FixedUpdate()
   // {
        //GetComponent<Rigidbody2D>().velocity = Vector2.right * input * speed;
    
   // }
}
