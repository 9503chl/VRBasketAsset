using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleS : MonoBehaviour
{
    public AudioSource TitleSound;

    void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.name == "StartGame")
        {
            TitleSound.Play();
            Invoke("StartG", 0.5f);
        }
        if (this.gameObject.name == "Quit")
        {
            TitleSound.Play();
            Invoke("QuitG", 0.5f);
        }
    }
    void StartG()
    {
        SceneManager.LoadScene("SelectStage");
    }
    void QuitG()
    {
        Application.Quit();
    }
}
