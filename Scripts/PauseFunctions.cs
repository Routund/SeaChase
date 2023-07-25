using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseFunctions : MonoBehaviour
{
    [SerializeField] private GameObject Gamepanel;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject DeathMenu;
    [SerializeField] private GameObject Map;
    public GameObject winMenu;
    public playerAttack playerAttack;


    // Start is called before the first frame update
    public void Start()
    {
        Pause();
        Resume();
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && PauseMenu.activeSelf)
        {
            Resume();
            
        }
        else if (Input.GetKeyUp(KeyCode.Escape))
        {
            Pause();
            
        }
        else if (!PauseMenu.activeSelf && Input.GetKeyDown(KeyCode.Tab))
        {
            Map.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            Map.SetActive(false);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        Gamepanel.SetActive(false);
        PauseMenu.SetActive(true);
        Map.SetActive(false);
        playerAttack.enabled = false;
        

    }

    public void Resume()
    {
        Time.timeScale = 1f;
        Gamepanel.SetActive(true);
        PauseMenu.SetActive(false);
        playerAttack.enabled=true;
        
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Win()
    {
        Pause();
        PauseMenu.SetActive(false);

        winMenu.SetActive(true);
    }
    public void Die()
    {
        Pause();
        PauseMenu.SetActive(false);
        
        DeathMenu.SetActive(true);
    }
    public void RestartScene()
    {

        Scene active = SceneManager.GetActiveScene();
        
        SceneManager.LoadScene(active.name);
        
    }

}
