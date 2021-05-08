using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] static float rTime = 5.2f;
    float RunTime = rTime;
    float x1 = 0.0f;
    float z1 = 0.0f;
    static bool fStart = true;
    // Update is called once per frame
    void Update()
    {
        if(fStart == true)
        {
            fStart = false;
            x1 = Random.Range(-17.0f, -9.0f);
            z1 = Random.Range(5.5f, 7f);
            transform.position = new Vector3(x1, 2.01f, z1);
        }
        RunTime -= Time.deltaTime;
        if(RunTime <= 0.0f)
        {
            x1 = Random.Range(-17.0f, -9.0f);
            z1 = Random.Range(5.5f, 7f);
            transform.position = new Vector3(x1, 2.01f, z1);
            RunTime = rTime;
        }
    }
}
