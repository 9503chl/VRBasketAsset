using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    //float time = 0.0f;
    float x1;
    Vector3 movement;
    Vector3 position;

    void Awake()
    {
        GetComponent<Rigidbody>();  
    }
    
    void Update()
    {
        transform.Translate(Vector3.forward * 0.002f); //이동에 문제가있따 무조건 뒤로만감
        //time += Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,Random.Range(0.0f,360.0f),0), Time.time);
    }
}
