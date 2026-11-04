using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPlayer : MonoBehaviour
{
    public Transform player;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        gameObject.transform.LookAt(player);
            
    }

    //Si quiero de se vuelva a ver el raton hay que poner esto
    //Cursor.visible = true;
    //Cursor.lockState = CursorLockMode.None;
    void Update()
    {
        
            
    }
}

