using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeManagerScript : MonoBehaviour
{
    public float power;

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = collision.gameObject.transform.position;

        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * power,ForceMode.Impulse);
    }
}
