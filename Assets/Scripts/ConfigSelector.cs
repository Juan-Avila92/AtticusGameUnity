using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigSelector : MonoBehaviour
{
    public GameObject config;
    public static bool toggle = false;

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
        if (!toggle)
        {
            config.SetActive(true);
            toggle = true;
        }
        else
        {
            config.SetActive(false);
            toggle = false;
        }
    }

}
