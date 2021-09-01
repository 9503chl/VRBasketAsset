using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleS : MonoBehaviour
{
    public AudioSource TitleSound;

    void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.name == "TouchPoint1")
        {
            TitleSound.Play();
            Invoke("StartG", 0.9f);
        }
        if (this.gameObject.name == "TouchPoint2")
        {
            TitleSound.Play();
            Invoke("QuitG", 0.9f);
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
