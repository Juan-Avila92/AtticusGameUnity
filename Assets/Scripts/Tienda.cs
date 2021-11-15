using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tienda : MonoBehaviour
{
    // Start is called before the first frame update
    public Text lupa;
    public Text monedas;
    public Text energia;
    public Text rubi;

    void Update()
    {
        monedas.text = CoinCounter.totalCoins.ToString();
    }

    public void Buy25Energy()
    {
        
        if(EnergyCounter.energy < 100 && CoinCounter.totalCoins > 50)
        {
            CoinCounter.totalCoins -= 50;
            EnergyCounter.energy += 25;
            energia.text = EnergyCounter.energy.ToString();
        }
    }

    public void Buy1Power()
    {
        
        if (CoinCounter.totalCoins > 100)
        {
            CoinCounter.totalCoins -= 100;
            Powers.powers += 1;
            lupa.text = Powers.powers.ToString();
        }
    }

    public void GoBackMenu()
    {
        SceneManager.LoadScene(5);
    }
}
