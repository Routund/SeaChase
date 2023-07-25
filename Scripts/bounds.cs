using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounds : MonoBehaviour
{
    public new Transform transform;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > -76 && player.position.x < 204)
        {
            transform.position = new Vector3(player.position.x,transform.position.y,-10);
        }
        if (player.position.y > -60 && player.position.y < 96)
        {
            transform.position = new Vector3(transform.position.x, player.position.y,-10);
        }
    }
}
