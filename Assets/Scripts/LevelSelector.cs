using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public async void OnMouseDown()
    {
        if (this.gameObject.tag == "Atico")
        {
            SceneManager.LoadScene(1);
        }

        if (this.gameObject.tag == "Cuarto")
        {
            SceneManager.LoadScene(3);
        }

        if (this.gameObject.tag == "Sala")
        {
            SceneManager.LoadScene(4);
        }

        if (this.gameObject.tag == "Biblioteca")
        {
            SceneManager.LoadScene(2);
        }

    }
}
