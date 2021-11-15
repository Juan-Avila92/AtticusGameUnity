using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLab : MonoBehaviour
{
    public void GoBackToLab()
    {
        SceneManager.LoadScene(11);
    }
}
