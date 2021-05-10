using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] int point = 2;
    [SerializeField] GameObject popupTextPrefab;
    Score score;
    void Start()
    {
        var gameObj = GameObject.FindWithTag("Score");
        score = gameObj.GetComponent<Score>();
    }
    void OnTriggerEnter(Collider other)
    {
        score.AddScore(point);
        CreatePopupText();
    }
    void CreatePopupText()
    {
        var text = Instantiate(popupTextPrefab, transform.position, Quaternion.identity);

        text.GetComponent<TextMesh>().text = string.Format("2µÊ¡°", point);
    }
}
