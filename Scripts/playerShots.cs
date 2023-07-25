using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerShots : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private BoxCollider2D collision;
    public float health = 10;
    public Vector2 rhitForce = Vector2.zero;
    public Vector2 lhitForce = Vector2.zero;
    bool isPushed = false;
    float timer = 0;
    float direction = 0;
    Vector2 force = Vector2.zero;
    private Movement movement;
    public GameObject[] hearts;
    public Sprite heartFull;
    public Sprite heartEmpty;

    // Start is called before the first frame update
    void Start()
    {
        collision = GetComponent<BoxCollider2D>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPushed)
        {
            if (direction > 0)
            {

                force = rhitForce;

            }
            else
            {
                force = lhitForce;

            }
            if (timer <= 30)
            {
                rigidbody.velocity = force*Time.deltaTime;
                timer++;
                movement.enabled = false;
            }
            else
            {
                isPushed = false;
                movement.enabled = true;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {

            health--;
            Debug.Log(health);
            direction = transform.position.x - collider.gameObject.transform.position.x;
            timer = 0;
            isPushed = true;
            for (int i = 0; i < hearts.Length; i++)
            {
                if (i <= health - 1)
                {
                    hearts[i].GetComponent<Image>().sprite = heartFull;
                }
                else
                {
                    hearts[i].GetComponent<Image>().sprite = heartEmpty;
                   
                }
            }
        }

    }
}
