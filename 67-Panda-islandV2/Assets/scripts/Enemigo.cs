using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pato : MonoBehaviour
{
    public float velocidad;
    public bool movimiento;
    public GameObject GameOver;
    public Player player;
    public AudioSource musica;



    void Start()
    {
    }

    void Update()
    {
        if (transform.position.x <= -0.194)
        {
            movimiento = false;
            gameObject.transform.localScale = new Vector3(0.05453808f, 0.05453808f, 0.05453808f);
        }
        else if (transform.position.x >= 0.183)
        {
            movimiento = true;
            gameObject.transform.localScale = new Vector3(0.05453808f, 0.05453808f, -0.05453808f);

        }
        if (movimiento == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * velocidad);
        }
        if (movimiento == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ddfd");

        if (collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Algo colisionó con el enemigo");
            collision.gameObject.SetActive(false);


            // Mostrar panel Game Over
            GameOver.SetActive(true);

            // Pausar juego
            Time.timeScale = 0f;

            // Parar música
            musica.Stop();
        }
    }
}