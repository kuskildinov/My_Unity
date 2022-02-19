using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomScript : MonoBehaviour
{
    public float TimeToExplosion;
    public float Power;
    public float Radius;
    Vector3 explousionCenter;

    void Boom()
    {
        Collider[] colliders = Physics.OverlapSphere(explousionCenter, Radius);
        foreach ( Collider B in colliders)
        {
            Rigidbody body = B.GetComponent<Rigidbody>();

            if (B != null && B.gameObject.layer != 10) body.AddExplosionForce(Power, explousionCenter, Radius, 30f);
        }
        TimeToExplosion = 3;
    }
    void Update()
    {
        TimeToExplosion -= Time.deltaTime;
        explousionCenter = transform.position;

        if(TimeToExplosion <= 0)
        {
            Boom();
        }
    }
}
