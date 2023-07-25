using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;
    public int shots = 4;
    public GameObject eventmanager;
    public GameObject[] cannonShots;
    public Sprite shotPresent;
    public Sprite shotNotPresent;

    public void updateShots()
    {
        for (int i = 0; i < cannonShots.Length; i++)
        {
            if (i <= shots - 1)
            {
                cannonShots[i].SetActive(true);
            }
            else
            {
                cannonShots[i].SetActive(false);

            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && shots > 0)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = (mousePos - transform.position).normalized;
            Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
            GameObject projectile = Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 0.03f), rotation,eventmanager.transform);
            projectile.GetComponent<Rigidbody2D>().velocity = direction * projectileSpeed;
            shots--;
            updateShots();
            
        }
    }
}
