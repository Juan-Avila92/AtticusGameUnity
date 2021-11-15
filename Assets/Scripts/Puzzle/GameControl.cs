using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject win;

    [SerializeField]
    float eulerAngX;

    public static bool hasWin;

    public string miniGame;

    void Start()
    {
        win.SetActive(false);
        hasWin = false;
    }

    // Update is called once per frame
    void Update()
    {



        if (miniGame == "Carta")
        {
            if (pictures[0].localEulerAngles.z == 270f &&
            pictures[1].localEulerAngles.z == 270f &&
            pictures[2].localEulerAngles.z == 270f &&
            pictures[3].localEulerAngles.z == 270f &&
            pictures[4].localEulerAngles.z == 270f &&
            pictures[5].localEulerAngles.z == 270f)
            {
                hasWin = true;
                win.SetActive(true);
            }
        }
        else
        {
            if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0)
            {
                hasWin = true;
                win.SetActive(true);
            }
        }

    }
}