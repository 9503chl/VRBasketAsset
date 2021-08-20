﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSel : MonoBehaviour
{
    public AudioSource StageSound;
    void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.name == "Stage1")
        {
            StageSound.Play();
            Invoke("Stage1", 0.5f);
        }
        if (this.gameObject.name == "Stage2")
        {
            StageSound.Play();
            Invoke("Stage2", 0.5f);
        }
        if (this.gameObject.name == "Stage3")
        {
            StageSound.Play();
            Invoke("Stage3", 0.5f);
        }
        if (this.gameObject.name == "Return")
        {
            StageSound.Play();
            Invoke("Return1", 0.5f);
        }
    }
    void Stage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    void Stage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    void Stage3()
    {
        SceneManager.LoadScene("Stage3");
    }
    void Return1()
    {
        SceneManager.LoadScene("Title");
    }

}