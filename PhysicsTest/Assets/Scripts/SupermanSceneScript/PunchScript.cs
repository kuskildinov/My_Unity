using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchScript : MonoBehaviour
{
    public float punchPower;
    
    private void OnCollisionEnter(Collision enemy)
    {        
            Vector3 direction = enemy.transform.position - transform.position;
            enemy.gameObject.GetComponent<Rigidbody>().AddForce(direction * punchPower * 1000);
    }


}
