using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TitleDoT : MonoBehaviour
{
    public GameObject VR;
    public GameObject BASKET;
    public GameObject BALL;
    public AudioSource A;

    void Start()
    {
        VR.transform.DOLocalMoveZ(100, 1).SetEase(Ease.InQuad);
        A.Play();
        Invoke("basket", 0.5f);
        Invoke("ball", 1.0f);
    }

    void basket()
    {
        BASKET.SetActive(true);
        BASKET.transform.DOLocalMoveZ(100, 1).SetEase(Ease.InQuad);
        A.Play();
    }
    void ball()
    {
        BALL.SetActive(true);
        BALL.transform.DOLocalMoveZ(100, 1).SetEase(Ease.InQuad);
        A.Play();
    }
}
