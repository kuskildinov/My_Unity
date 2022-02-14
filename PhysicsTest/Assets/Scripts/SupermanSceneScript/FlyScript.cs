using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public float speed;
    public bool fly;
    
    public Transform FinishPoint;

       
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, FinishPoint.position, Time.deltaTime * speed);

    }
}
