using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveScript : MonoBehaviour
{
    public int speed;   
    public Transform finishPoint;

    
    void Update()        
    {
      transform.position = Vector3.MoveTowards(transform.position, finishPoint.position, speed * Time.deltaTime);  // перемещение к конечной точке
    }

}
