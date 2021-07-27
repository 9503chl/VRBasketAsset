using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Score : MonoBehaviour
{
    Text uiText;
    public int Points { get; private set; }
    float iTime;

    void Start()
    {
        uiText = GetComponent<Text>();
    }
    public void AddScore(int addPoint)
    {
        if (iTime <= 15.0f)
        {
            Points += addPoint + 1;
            uiText.text = string.Format("점수 : {0:D2}점", Points);
        }
        else
        {
            Debug.Log(iTime);
            Points += addPoint;
            uiText.text = string.Format("점수 : {0:D2}점", Points);
        }
    }
    void Update()
    {
        iTime = GameObject.Find("Canvas").GetComponent<RemainTimer>().currentTime;
    }
}
