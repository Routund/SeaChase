using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupBehavior : MonoBehaviour
{
    private playerAttack attack;
    private GameObject InstantiatedMarker;
    public GameObject marker;
    public GameObject map;
    // Start is called before the first frame update
    void Start()
    {
        map = GameObject.Find("Map");
        attack = GameObject.Find("Pirates").GetComponent<playerAttack>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            attack.shots++;
            attack.updateShots();
            Destroy(InstantiatedMarker);
            Destroy(this.gameObject);
        }
    }
}
