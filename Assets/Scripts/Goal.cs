using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] int point = 2;
    [SerializeField] GameObject popupTextPrefab;
    [SerializeField] AudioSource GoalAudioSource;
    [SerializeField] GameObject ThreeptspopupTextPrefab;
    [SerializeField] AudioSource ThreeptsGoalAudioSource;
    Score score;
    float iTime;
    void Start()
    {
        var gameObj = GameObject.FindWithTag("Score");
        score = gameObj.GetComponent<Score>();
    }
    void OnTriggerEnter(Collider other)
    {
        score.AddScore(point);
        if(iTime <= 15.0f)
        {
            ThreeptsGoalAudioSource.Play();
        }
        else
        {
            GoalAudioSource.Play();
        }
        CreatePopupText();
    }
    void CreatePopupText()
    {
        if (iTime <= 15.0f)
        {
            var text = Instantiate(ThreeptspopupTextPrefab, transform.position, Quaternion.identity);
            text.GetComponent<TextMesh>().text = string.Format("3µÊ¡°", point+1);
        }
        else {
            var text = Instantiate(popupTextPrefab, transform.position, Quaternion.identity);
            text.GetComponent<TextMesh>().text = string.Format("2µÊ¡°", point);
        }
    }
    void Update()
    {
        iTime = GameObject.Find("Canvas").GetComponent<RemainTimer>().currentTime;
    }
}
