using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePuzzle : MonoBehaviour
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
        if (!GameControl.hasWin)
        {
            transform.Rotate(0f, 0f, 90f);
        }
    }
}
