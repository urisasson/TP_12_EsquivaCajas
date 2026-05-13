using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{

    public float speed;
    private bool activo = true; // >>> AGREGADO
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!activo) return; // >>> AGREGADO
        transform.Translate(0,-speed * Time.deltaTime,0);
    }
     public void Detener() // >>> AGREGADO
    {
        activo = false;
    }
}
