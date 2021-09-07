using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{

    public GameObject ShootingBall;
    public Transform firePos;
    public GameObject Hand1,OnHand;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            ShootBall();
        }
        //if (gameObject.transform.eulerAngles)
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            ShootBall();
        }
#endif
    }
    void ShootBall()
    {
        Instantiate(ShootingBall, firePos.position, firePos.rotation);
    }
}
