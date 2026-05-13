using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int posicion = 0; // -1 izquierda, 0 centro, 1 derecha // >>> AGREGADO

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (posicion < 1) // >>> AGREGADO
            {
                posicion++; // >>> AGREGADO
                transform.Translate(2f, 0, 0);
            }
        }
         if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (posicion > -1) // >>> AGREGADO
            {
                posicion--; // >>> AGREGADO
                transform.Translate(-2f, 0, 0);
            }
    }
  }
}