using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    public float xMin = -4f;        // >>> AGREGADO
    public float xMax = 4f;         // >>> AGREGADO
    public float alturaSpawn = 8f;  // >>> AGREGADO
    public float incrementoVelocidad = 0.5f; // >>> AGREGADO

    private CajaMovement cajaMovement; // >>> AGREGADO
    // Start is called before the first frame update
    void Start()
    {
        cajaMovement = GetComponent<CajaMovement>(); // >>> AGREGADO
        Reposicionar(); // >>> AGREGADO
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player")){
            cajaMovement.Detener(); // >>> AGREGADO
            GameM.Instance.DetenerTiempo(); // >>> AGREGADO
            Destroy(col.gameObject);
        }else if(col.gameObject.CompareTag("Piso")){
             cajaMovement.speed += incrementoVelocidad; // >>> AGREGADO
             Reposicionar(); // >>> AGREGADO
        }
    }
     void Reposicionar() // >>> AGREGADO
    {
        float x = Random.Range(xMin, xMax);
        transform.position = new Vector3(x, alturaSpawn, 0f);
    }
}
