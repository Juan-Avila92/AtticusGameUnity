using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;
    public GameObject finish;
    public Text numberOfCoins;
    public int itemCounter = 0;
    public string level;

    private bool countCoin;
    // Start is called before the first frame update
    void Start()
    {
        countCoin = false;
        
    }

    // Update is called once per frame
    async void FixedUpdate()
    {
        if (!object1.activeInHierarchy && !object2.activeInHierarchy && !object3.activeInHierarchy
            && !object4.activeInHierarchy && !object5.activeInHierarchy)
        {
            if (!countCoin)
            {
                CoinCounter.totalCoins += GetNumberOfCoins();
               numberOfCoins.text = CoinCounter.totalCoins.ToString();

                EnergyCounter.energy -= 25;
            }

            countCoin = true;

            await Task.Delay(1000);
            finish.SetActive(true);
            await Task.Delay(3000);

            if(level == "Atico")
            {
                Level.atticLevel = true;
                SceneManager.LoadScene(6);
            }

            if (level == "Sala")
            {
                Level.livingRoomLevel = true;
                SceneManager.LoadScene(7);
            }

            if(level == "Biblioteca")
            {
                Level.libraryLevel = true;
                SceneManager.LoadScene(8);
            }

            if(level == "Cuarto")
            {
                Level.bedroomLevel = true;
                SceneManager.LoadScene(5);
            }
        }
    }

    public int GetNumberOfCoins()
    {
        return Random.Range(50, 250);
    }

}
