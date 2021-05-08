using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GazeHoldEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] float gazeTapTime = 2.0f; //��Ÿ��
    [SerializeField] UnityEvent onGazeHold; //�� �̺�Ʈ

    float timer; //�����ð�
    bool isHover; //������ �ִ°�

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
