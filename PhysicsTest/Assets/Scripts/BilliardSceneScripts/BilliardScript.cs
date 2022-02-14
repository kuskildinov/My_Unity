using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilliardScript : MonoBehaviour
{
    public GameObject centralBall;
    public float PushPower;

    private bool StartButtonPushed;

    public Transform point;

    private void Start()
    {
        //point.position = centralBall.transform.position;
    }
    void Update()
    {
        Vector3 direction = point.position - transform.position;
        if(StartButtonPushed)
        {
            GetComponent<Rigidbody>().AddForce(direction.normalized * PushPower, ForceMode.Impulse);
            StartButtonPushed = false;
        }
    }

    public void StartButon()
    {
        StartButtonPushed = true;
    }

}
