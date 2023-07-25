using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning_animator : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite frontFacing;
    public Sprite backFacing;
    public Sprite sideFacing;
    public Rigidbody2D rigidbody;
    public BoxCollider2D collider;
    public Vector2 side_offset = new Vector2(0,-(1/4));
    public Vector2 sideProportions = new Vector2(2,1);
    public Vector2 verticalProperties = new Vector2(1, 2);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.velocity.magnitude != 0)
        {
            if (Mathf.Abs(rigidbody.velocity.y) > Mathf.Abs(rigidbody.velocity.x))
            {
                if (0 > rigidbody.velocity.y)
                {
                    sr.sprite = frontFacing;
                    collider.size = verticalProperties;
                    collider.offset = Vector2.zero;
                }
                else
                {
                    sr.sprite = backFacing;
                    collider.size = verticalProperties;
                    collider.offset = Vector2.zero;
                }

            }
            else if (0 > rigidbody.velocity.x)
            {
                sr.sprite = sideFacing;
                collider.size = sideProportions;
                collider.offset = side_offset;
                sr.flipX = true;
            }
            else
            {
                sr.sprite = sideFacing;
                collider.size = sideProportions;
                collider.offset = side_offset;
                sr.flipX = false;
            }
        }

    }
}
