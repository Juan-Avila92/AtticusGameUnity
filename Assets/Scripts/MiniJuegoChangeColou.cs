using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniJuegoChangeColou : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Renderer button;

    // Update is called once per frame
    void Update()
    {
        if (Level.atticLevel && Level.bedroomLevel
            && Level.libraryLevel && Level.livingRoomLevel)
        {
            button.material.color = Color.red;
        }
    }
}
