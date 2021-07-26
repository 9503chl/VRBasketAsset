using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] static float rTime = 5.2f;
    public float RunTime = rTime;
    public float x1 = 0.0f;
    public float z1 = 0.0f;
    static bool fStart = true;
    void Update()
    {
        if(fStart == true)
        {
            fStart = false;
            x1 = Random.Range(-15.0f, -10.0f);
            z1 = Random.Range(6.0f, 7.0f);
            transform.position = new Vector3(x1, 2.01f, z1);
        }
        RunTime -= Time.deltaTime;
        if(RunTime <= 0.0f)
        {
            x1 = Random.Range(-15.0f, -10.0f);
            z1 = Random.Range(6.0f, 7.0f);
            transform.position = new Vector3(x1, 2.01f, z1);
            RunTime = rTime;
        }
    }
}
