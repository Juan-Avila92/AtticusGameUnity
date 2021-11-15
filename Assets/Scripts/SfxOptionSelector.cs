using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxOptionSelector : MonoBehaviour
{
    public GameObject sfxOn;
    public GameObject sfxOff;
    public GameObject soundFx;
    public static bool toggle;

    // Update is called once per frame
    void FixedUpdate()
    {
    }

    public void OnMouseDown()
    {
        if (!toggle)
        {
            sfxOn.SetActive(false);
            sfxOff.SetActive(true);
            soundFx.SetActive(false);
            toggle = true;
        }
        else
        {
            sfxOn.SetActive(true);
            sfxOff.SetActive(false);
            soundFx.SetActive(true);
            toggle = false;
        }
    }
}
