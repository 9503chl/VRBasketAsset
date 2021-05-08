using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GazeHoldEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] float gazeTapTime = 2.0f; //탭타임
    [SerializeField] UnityEvent onGazeHold; //탭 이벤트

    float timer; //영역시간
    bool isHover; //영역에 있는가

    public void OnPointerEnter(PointerEventData eventData)
    {
        timer = 0.0f;
        isHover = true;
    }

    public void OnPointerExit(PointerEventData evnetData)
    {
        isHover = false;
    }

    public void Update()
    {
        if (!isHover)
        {
            return;
        }
        timer += Time.deltaTime;

        if(gazeTapTime < timer)
        {
            onGazeHold.Invoke();

            isHover = false;
        }
    }
}
