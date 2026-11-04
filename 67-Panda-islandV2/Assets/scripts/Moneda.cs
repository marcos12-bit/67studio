using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Moneda : MonoBehaviour
{
    public TMP_Text textCoins;
    private static int coins;
    public int coinsTotales = 50;
    public GameObject Victoria;
    public AudioSource musica;
    

    private void OnTriggerEnter(Collider Colision)
    {
        if (Colision.CompareTag("Player"))
        {

            Debug.Log("Moneda recogida!");
            Destroy(gameObject); // Destruye la moneda después de recogerla
            coins++;
            

            if (coins >= coinsTotales)
            {
                Victoria.SetActive(true);
                musica.Stop();
                Time.timeScale = 0f;
            }
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
