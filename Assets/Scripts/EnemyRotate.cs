using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    float time = 0.0f;
    float x1;
    Vector3 movement;
    Vector3 position;
    public Transform targetTransform; //다른 오브젝트 가져오는 쉬운방법
    Rigidbody rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();  
    }

    void Update()
    {
        transform.Translate(Vector3.forward * 0.002f); //가는방향
        time += Time.deltaTime;
        transform.LookAt(targetTransform);
        if (time >= 2.0f)
        {
            rigid.AddForce(Vector3.up , ForceMode.Impulse);
            time = 0.0f;
        }
    }
}
