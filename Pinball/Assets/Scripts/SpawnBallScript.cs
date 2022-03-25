using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallScript : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPoint;
    
    void Start()
    {
        transform.position = transform.position;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == ball)
        ball.transform.position = spawnPoint.position;
    }

}
