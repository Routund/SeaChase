using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthManager : MonoBehaviour
{
    public int playerHealth = 5;
    public int tankerHealth = 20;
    public PauseFunctions pauseFunctions;
    public GameObject Tank_Slider;
    public Slider Ship_Slider;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tank_Slider.GetComponent<Slider>().value = tankerHealth;
        Ship_Slider.value = playerHealth;
        if (tankerHealth == 0)
        {
            pauseFunctions.Win();
        }
        if(playerHealth == 0)
        {
            pauseFunctions.Die();
        }
    }
}
