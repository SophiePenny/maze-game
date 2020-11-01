using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class rabbitmove : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    // Update is called once per frame
    void Update()
    {
        Vector2 Velocity = rb.velocity;
        if (Input.GetKey("a"))
        {
            Velocity.x = -100;
        }
        if (Input.GetKey("d"))
        {
            Velocity.x = 100;
        }
        rb.velocity = Velocity;
        Velocity.y = 0;
    }
}
