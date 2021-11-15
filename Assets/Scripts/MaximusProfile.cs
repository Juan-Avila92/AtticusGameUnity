using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaximusProfile : MonoBehaviour
{
    public GameObject profile1;

    public void OnMouseDown()
    {
        profile1.SetActive(true);
    }

    public void Close()
    {
        profile1.SetActive(false);
    }
}
