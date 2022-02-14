using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOScript : MonoBehaviour
{
    public float LightPower;
    public Transform ufoCenter;
    private void OnTriggerStay(Collider other)
    {
       
        if (other.attachedRigidbody)
        {
           
            Vector3 direction = ufoCenter.position - other.gameObject.transform.position;         
            other.attachedRigidbody.useGravity = false;
            other.attachedRigidbody.AddForce(direction.normalized * LightPower);
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.useGravity = true;
    }
}
