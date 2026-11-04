using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformaanimada : MonoBehaviour
{
    public float velocidad;
    public bool movimiento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 0.633)
        {
            movimiento = false;
            gameObject.transform.localScale = new Vector3(0.4471033f, 0.05545578f, 0.4970221f);
        }
        else if (transform.position.x >= 1.991)
        {
            movimiento = true;
            gameObject.transform.localScale = new Vector3(0.4471033f, 0.05545578f,-0.4970221f);

        }
        if (movimiento == false)
        {
            transform.Translate(Vector3.right * Time.deltaTime * velocidad);
        }
        if (movimiento == true)
        {
            transform.Translate(Vector3.left * Time.deltaTime * velocidad);
        }
    }
}
