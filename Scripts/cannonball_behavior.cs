using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonball_behavior : MonoBehaviour
{
    private int lifeSpan = 0;
    private GameObject tanker;
    public GameObject pickupPrefab;
    public GameObject inWater;
    public GameObject outWater;
    
    
    // Start is called before the first frame update
    void Start()
    {
        tanker = GameObject.Find("Tanker");
    }

    // Update is called once per frame
    void Update()
    {
        lifeSpan ++;
        if (lifeSpan > 240)
        {
            GameObject.Find("eventManager").GetComponent<PickupInstantiater>().instantiatePickup(transform);
            Instantiate(inWater, transform.position + new Vector3(0, 0, 05f), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tanker"))
        {

            GetComponentInParent<healthManager>().tankerHealth--;
            GameObject.Find("eventManager").GetComponent<PickupInstantiater>().instantiatePickup(transform);
            Instantiate(outWater, transform.position + new Vector3(0, 0, 05f), Quaternion.identity);
            
            Destroy(this.gameObject);
        }
        else if (collision.CompareTag("Obstacle"))
        {
            Instantiate(pickupPrefab, transform.position+new Vector3(0,0,0.05f), Quaternion.identity);

            Destroy(this.gameObject);
        }

    }
}
