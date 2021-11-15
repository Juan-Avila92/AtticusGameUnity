using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsesinoScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string asesino;
    public string result;
    public GameObject fin;
    public GameObject gameOver;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        asesino = "Martha";
    }

    public void OnMouseDown()
    {
        if(this.gameObject.tag == asesino)
        {
            result = string.Format("{0} es la asesina", this.gameObject.tag);
            fin.SetActive(true);
        }
        else
        {
            gameOver.SetActive(true);
            result = string.Format("{0} No es el asesino", this.gameObject.tag);
        }
    }
}
