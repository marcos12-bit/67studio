using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject Pause_menu;
    public bool isPaused;

    void Start()
    {
        isPaused = false;
        if (Pause_menu != null)
        {
            Pause_menu.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0.0f;

        if (Pause_menu != null)
        {
            Pause_menu.SetActive(true);
        }

        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1.0f;

        if (Pause_menu != null)
        {
            Pause_menu.SetActive(false);
        }

        
         Cursor.lockState = CursorLockMode.Locked;
         Cursor.visible = false;
    }

    
    public void ReiniciarJuego()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    
    public void VolverAlMenu()
    {
        Time.timeScale = 1f;
        Application.Quit(0); 
    }

    
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    public void QuitToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}