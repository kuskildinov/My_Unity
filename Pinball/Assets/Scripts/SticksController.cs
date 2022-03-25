using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SticksController : MonoBehaviour
{
    public GameObject LeftStick;
    public GameObject RigthStick;

    HingeJoint LeftStickJoint;
    HingeJoint RightStickJoint;

    private void Start()
    {
        LeftStickJoint = LeftStick.GetComponent<HingeJoint>();
        RightStickJoint = RigthStick.GetComponent<HingeJoint>();
    }

    void Update()
    {
        LeftStickJoint.useMotor = Input.GetKey(KeyCode.LeftArrow);
        RightStickJoint.useMotor = Input.GetKey(KeyCode.RightArrow);
    }
}
