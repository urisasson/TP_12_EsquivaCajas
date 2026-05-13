using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Si usas Text normal borrá esto y poné: using UnityEngine.UI;


public class GameM : MonoBehaviour
{
 public static GameM Instance;
public TextMeshProUGUI timerText;

 private float tiempo = 0f;
    private bool activo = true;




    // Start is called before the first frame update
    void Start()
    {
         Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!activo) return;
        tiempo += Time.deltaTime;
        timerText.text = tiempo.ToString("F2") + "s";
    }
    public void DetenerTiempo()
    {
        activo = false;
    }
}
