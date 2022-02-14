using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMoveScript : MonoBehaviour
{
    public GameObject[] points = new GameObject[8];  //Массив точек 
     Vector3[] pointsPosition = new Vector3[8]; //Позиции точке для движений;

    Vector3 target;
    public float Speed;

    void Start()
    {
        for (int i = 0; i < points.Length; i++)
        {
            pointsPosition[i] = points[i].transform.position;
        }

        transform.position = pointsPosition[0];
        target = pointsPosition[1];
    }

   
    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, target, Speed * Time.deltaTime);
        
        for (int i = 1; i < pointsPosition.Length - 1; i++)
        {
            if(transform.position == pointsPosition[i])
            {
                target = pointsPosition[i + 1];
            }
        }
        
    }
}
