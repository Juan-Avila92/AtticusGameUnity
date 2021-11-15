using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MusicOptionSelector : MonoBehaviour
{

    public GameObject musicOn;
    public GameObject musicOff;
    public AudioSource audioSource;
    public bool mouseState;
    public static bool toggle;

    // Update is called once per frame
    void FixedUpdate()
    {
    }

    public void OnMouseDown()
    {
        if (!toggle) {
            musicOn.SetActive(false);
            musicOff.SetActive(true);
            Camera.main.GetComponent<AudioSource>().Pause();
            toggle = true;
        } else
        {
            musicOn.SetActive(true);
            musicOff.SetActive(false);
            Camera.main.GetComponent<AudioSource>().Play();
            toggle = false;
        }
    }
}
