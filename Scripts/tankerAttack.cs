using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankerAttack : MonoBehaviour
{
    public TankerPathfinding movement;
    public Transform pirates;
    public float attackRange = 5;
    public float attackSpeed = 30;
    public float attackTime = -1;
    public GameObject BulletsPrefab;
    private Rigidbody2D rb;
    private bool attacking = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movement.enabled = true;
        attackTime = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if ((pirates.position - transform.position).magnitude <= attackRange && !attacking)
        {
            movement.enabled = false;
            rb.velocity = Vector2.zero;
            attackTime = 0;
            attacking = true;
        }
        else if (attacking && (pirates.position - transform.position).magnitude > attackRange)
        {
            movement.enabled = true;
            attackTime = -1;
            attacking = false;
        }

        if (attackTime <= attackSpeed && attackTime >= 0 && attacking)
        {
            attackTime++;
        }
        else if (attackTime >= attackSpeed)
        {
            Vector3 direction = (pirates.position - transform.position).normalized;
            Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
            Instantiate(BulletsPrefab, transform.position+direction*3 + new Vector3(0, 0, 0.05f), rotation);
            attackTime = 0;
        }
        
        
        
    }
}
