using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RimRotator : MonoBehaviour
{
    Vector3 position;
    float time1 = 0.0f;
    float time2 = 5.2f;
    float px, pz = 0.0f;
    void Start()
    {
        position = transform.position;
    }

    void Update()
    {
        if (time2 <= 0.0f)
        {
            px = GameObject.Find("GoalDae").GetComponent<Rotator>().x1;
            pz = GameObject.Find("GoalDae").GetComponent<Rotator>().z1;
            transform.position = new Vector3(px, -0.48f, pz);
            time2 = 5.2f;
        }
        else
        {
            time2 -= Time.deltaTime;
            time1 += Time.deltaTime;
            if (time1 <= 1.5f)
            {
                position.x += 0.5f * Time.deltaTime;
            }
            else if (time1 >= 1.5f)
            {
                position.x -= 0.5f * Time.deltaTime;
            }
            if (time1 >= 3.0) time1 = 0.0f;
            transform.position = position;
        }
    }
}
