using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text numberOfCoins;
    public Text energy;
    public Text power;
    // Start is called before the first frame update
    public static int totalCoins;

    void Update()
    {
        numberOfCoins.text = totalCoins.ToString();
        energy.text = EnergyCounter.energy.ToString();
        power.text = Powers.powers.ToString();
    }
}
