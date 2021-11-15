using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabOpener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (Level.atticLevel && Level.bedroomLevel
            && Level.libraryLevel
             && Level.livingRoomLevel)
        {
            SceneManager.LoadScene(11);
        }
    }
}
