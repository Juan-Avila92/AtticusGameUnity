using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgathaProfile : MonoBehaviour
{
    public GameObject profile3;

    public void OnMouseDown()
    {
        profile3.SetActive(true);
    }

    public void Close()
    {
        profile3.SetActive(false);
    }
}
