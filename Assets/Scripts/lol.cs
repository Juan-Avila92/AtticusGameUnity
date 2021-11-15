using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lol : MonoBehaviour
{

    public Text TextTimer;
    public float Tiempo = 100;// 01:30

    public bool GameActive = true;
    public GameObject CanvasPerder;

    void SetText()
    {
        int Minutos = Mathf.FloorToInt(Tiempo / 60);// 01
        int Segundos = Mathf.FloorToInt(Tiempo % 60);// 30
        TextTimer.text = Minutos.ToString("00") + ":" + Segundos.ToString("00");
    }

    float s;

    private void Update()
    {
        if (GameActive) 
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Tiempo--;
                s = 0;
            }
        }
        
        if(GameActive && Tiempo <= 0)
        {
            Debug.Log("Game Over");
            CanvasPerder.SetActive(true);
            GameActive = false;
        }


        SetText();
        
    }
}
