using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer atticLevel;
    public Renderer livingRoom;
    public Renderer library;
    public Renderer bedroom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Level.atticLevel)
        {
            atticLevel.material.color = Color.gray;
        }

        if (Level.bedroomLevel)
        {

            bedroom.material.color = Color.gray;
        }

        if (Level.libraryLevel)
        {

            library.material.color = Color.gray;
        }

        if (Level.livingRoomLevel)
        {
            livingRoom.material.color = Color.gray;
        }
    }
}
