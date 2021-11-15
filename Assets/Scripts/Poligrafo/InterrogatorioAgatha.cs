using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterrogatorioAgatha : MonoBehaviour
{
    public GameObject questions;
    public GameObject blockButton;
    public AudioSource answer;
    public Slider mentira;
    public Slider verdad;
    // Start is called before the first frame update
    private void Awake()
    {
        mentira.value = 0;
        verdad.value = 0;
    }
    void Start()
    {
        answer.Stop();
    }

    // Update is called once per frame
    void Update()
    {


        if (!answer.isPlaying)
        {
            answer.gameObject.SetActive(false);
            blockButton.SetActive(false);
        }
        else
        {
            
        }


        
    }

    public void OpenQuestioning()
    {
        questions.SetActive(true);
    }

    public void PlayAnswer()
    {
        answer.gameObject.SetActive(true);
        blockButton.SetActive(true);

        if(this.gameObject.tag == "respuesta1")
        {
            verdad.value = 0.6f;
            mentira.value = 0.4f;
        }

        if (this.gameObject.tag == "respuesta2")
        {
            verdad.value = 0.6f;
            mentira.value = 0.4f;
        }

        if (this.gameObject.tag == "respuesta3")
        {
            verdad.value = 0.4f;
            mentira.value = 0.6f;
        }

        if (this.gameObject.tag == "respuesta4")
        {
            verdad.value = 0.6f;
            mentira.value = 0.4f;
        }

    }

    public void ExistQuestions()
    {
        questions.SetActive(false);
    }
}
