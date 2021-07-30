using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    float time = 0.0f;
    float x1;
    Vector3 movement;
    Vector3 position;

    void Awake()
    {
        GetComponent<Rigidbody>();  
    }

    void Update()
    {
        transform.Translate(Vector3.forward * 0.002f); //가는방향
        time += Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(GameObject.Find("GoalDae").GetComponent<Transform>().position);

        if (time >= 1.5f)
        {
            time = 0.0f;
        }
    }
}
