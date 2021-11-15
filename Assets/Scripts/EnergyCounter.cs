using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyCounter : MonoBehaviour
{
    public Text amountOfEnergy;
    public static int energy;

    void Start()
    {
        amountOfEnergy.text = energy.ToString();
    }
    
}
