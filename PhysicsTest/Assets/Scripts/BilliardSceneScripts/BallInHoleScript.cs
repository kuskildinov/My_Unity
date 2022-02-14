using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallInHoleScript : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);       
       
    }
}
