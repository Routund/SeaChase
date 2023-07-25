using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracktomap : MonoBehaviour
{
    public Transform objectTorack;
    public RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (objectTorack == null)
        {
            objectTorack = GetComponentInParent<Transform>();
        }
        rect.position = new Vector3(Mathf.Abs(-96-objectTorack.position.x)* 1.8934169279f*1.8f, Mathf.Abs(-71 - objectTorack.position.y)*1.7f* 1.9209039548f, transform.position.z);
    }
}
