using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWait : MonoBehaviour
{
    float time = 2.0f;

    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0.0f)
        {
            gameObject.SetActive(false);
        }
    }
}
