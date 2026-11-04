using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bambu : MonoBehaviour
{
    public TMP_Text Bambus;
    private static int Bambuu;

    private void OnTriggerEnter(Collider Colision)
    {
        if (Colision.CompareTag("Player"))
        {

            Debug.Log("Bambus recogidos!");
            Destroy(gameObject); // Destruye la moneda después de recogerla
            Bambuu++;
            
        }
    }
            // Start is called before the first frame update
            void Start()
            {
                Bambuu = 0;
            }

    
            // Update is called once per frame
            void Update()
            {
        
            }
}
