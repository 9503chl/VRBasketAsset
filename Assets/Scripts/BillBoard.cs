﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.forward = GameObject.Find("Main camera").GetComponent<Camera>().transform.forward;
    }
}
