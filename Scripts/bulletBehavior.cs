using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehavior : MonoBehaviour
{
    private tankerAttack tankerAttackScript;
    private GameObject pirates;
    private healthManager healthManager;
    private int timer = 0;
    public GameObject hitSound;
    // Start is called before the first frame update
    void Start()
    {
        tankerAttackScript = GameObject.Find("Tanker").GetComponent<tankerAttack>();
        healthManager = GameObject.Find("eventManager").GetComponent<healthManager>();
        pirates = GameObject.Find("Pirates");
        tankerAttackScript.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if ((pirates.transform.position - tankerAttackScript.transform.position).magnitude >=tankerAttackScript.attackRange || timer>=250)
        {
            tankerAttackScript.enabled=true;
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            healthManager.playerHealth--;
            Instantiate(hitSound);
        }
    }
}
