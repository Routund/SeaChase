using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public new BoxCollider2D collider2D;
    public Rigidbody2D rb;
    public float speed = 500;
    public float maxSpeed = 10f;
    private Vector2 north;
    private Vector2 east;
    public AudioSource water;



    // Start is called before the first frame update
    void Start()
    {
        
        north = new Vector2(0, speed);
        east = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.anyKey)
        {
            if (Input.GetKey("a"))
            {
                rb.AddForce(-east);
            }
            if (Input.GetKey("s"))
            {
                rb.AddForce(-north);
            }
            if (Input.GetKey("w"))
            {
                rb.AddForce(north);
            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(east);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                rb.velocity *= 0.93f;
            }
            if (!water.isPlaying)
            {
                water.enabled = true;
                water.Play();
                
            }
            water.volume *= 1.05f;
        }
        else
        {
            rb.velocity *= 0.99f;
            water.volume *= 0.99f;
        }

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}