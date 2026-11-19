using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zonamuerte : MonoBehaviour

{
    public GameObject GameOver;
    
    public AudioSource musica;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Algo entró");

        if (other.CompareTag("Player"))
        {

            Debug.Log("El jugador ha muerto.");
            

        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Detener jugador
        

        // Mostrar panel Game Over
        GameOver.SetActive(true);

        // Pausar juego
        Time.timeScale = 0f;

        


    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}


