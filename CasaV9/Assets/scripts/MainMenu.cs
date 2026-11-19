using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject volumen;
    public GameObject menu;
    public GameObject volver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void volvermenuvolumen()
    {
        volumen.SetActive(false);
        menu.SetActive(true);
    }
    public void options()
    {
        volumen.SetActive(true);
        menu.SetActive(false);
    }
    
    public void Cargarjuego()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void SetMusicVol()
    {

    }
    public void despausaJefe()
    {


    }

    public void recargarescena()
    {
        SceneManager.LoadScene(2);


    }

    

    public void MenuPrincipal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");

    }
}

