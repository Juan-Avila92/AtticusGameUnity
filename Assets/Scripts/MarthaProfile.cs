using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarthaProfile : MonoBehaviour
{
    public GameObject profile2;

    public void OnMouseDown()
    {
        profile2.SetActive(true);
    }

    public void Close()
    {
        profile2.SetActive(false);
    }
}
