using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{   
    public float power;
    bool StartPosition;
        
    void Update()
    {
        Vector3 direction = new Vector3(0.0f, 1.0f, 0.0f);
        if (Input.GetKeyDown(KeyCode.Space) && StartPosition)
        {
            GetComponent<Rigidbody>().AddForce(direction.normalized * power, ForceMode.Impulse);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        StartPosition = true;       
    }

    private void OnTriggerExit(Collider other)
    {
        StartPosition = false;
    }     
}
