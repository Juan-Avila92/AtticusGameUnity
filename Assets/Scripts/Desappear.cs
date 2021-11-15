using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Desappear : MonoBehaviour
{
    public GameObject smokeParticles;
    public AudioSource selectedItemSound;
    private void Start()
    {
        smokeParticles.SetActive(false);
        selectedItemSound.Stop();
    }
    private async void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        if (!this.gameObject.activeInHierarchy)
        {
            selectedItemSound.Play();
        }
        smokeParticles.SetActive(true);
        await Task.Delay(1000);
        smokeParticles.SetActive(false);
    }
}
   



