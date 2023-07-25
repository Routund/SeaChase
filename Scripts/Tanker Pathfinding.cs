using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankerPathfinding : MonoBehaviour
{
    public float speed = 0;
    public int delay = 0;
    public int delayLimit = 30;
    public Transform Player;
    public Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (delay < delayLimit)
        {
            delay++;
        }
        else
        {
            Vector2 playerDirection = Player.position - transform.position;
            float angle = Vector2.SignedAngle(Vector2.up, playerDirection);
            if (-22.5 < angle && angle <= 22.5)
            {
                rb.velocity = Vector2.up.normalized * speed;
            }
            else if (-67.5 < angle && angle <= -22.5)
            {
                rb.velocity = (Vector2.right + Vector2.up).normalized * speed;
            }
            else if (-112.5 < angle && angle <= -67.5)
            {
                rb.velocity = Vector2.right.normalized * speed;
            }
            else if (-157.5 < angle && angle <= -112.5)
            {
                rb.velocity = (Vector2.right + Vector2.down).normalized * speed;
            }
            else if ((157.5 < angle || angle <= -157.5))
            {
                rb.velocity = Vector2.down.normalized * speed;
            }
            else if (112.5 < angle && angle <= 157.5)
            {
                rb.velocity = (Vector2.left + Vector2.down).normalized * speed;
            }
            else if (67.5 < angle && angle <= 112.5)
            {
                rb.velocity = Vector2.left.normalized * speed;
            }
            else if (22.5 < angle && angle <= 67.5)
            {
                rb.velocity = (Vector2.left + Vector2.up).normalized * speed;
            }
            delay = 0;
        }
    }
}