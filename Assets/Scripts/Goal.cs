using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] int point = 2;
    Score score;
    void Start()
    {
        var gameObj = GameObject.FindWithTag("Score");
        score = gameObj.GetComponent<Score>();
    }
    void OnTriggerEnter(Collider other)
    {
        score.AddScore(point);
    }
}
