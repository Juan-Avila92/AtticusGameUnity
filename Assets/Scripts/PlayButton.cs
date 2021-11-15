using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    public void PLayGame()
    {
        EnergyCounter.energy = 100;
        Powers.powers = 0;
        SceneManager.LoadScene(5);
    }

}
