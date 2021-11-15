using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private bool isCollected = false;

    public bool Collected(){
        if (isCollected)
            return false;
        Destroy(gameObject);
        return true;
    }
   
}
