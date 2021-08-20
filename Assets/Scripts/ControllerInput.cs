using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{

    public GameObject ShootingBall;
    public Transform firePos;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            ShootBall();
        }
        if (Input.GetMouseButtonDown(0))
        {
            ShootBall();
        }
    }
    void ShootBall()
    {
        Instantiate(ShootingBall, firePos.position, firePos.rotation);
    }
}
