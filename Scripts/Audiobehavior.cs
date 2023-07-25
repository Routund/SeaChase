using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiobehavior : MonoBehaviour
{
    int delay = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay++;
        if (delay >= 60)
        {
            Destroy(this.gameObject);
        }
    }
}
