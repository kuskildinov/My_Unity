using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// В случайном порядке начинает игру за одно из призраков
/// </summary>
public class GhostsRandom : MonoBehaviour
{
    int rand;

    public GameObject blueGhost;
    public GameObject yellowGhost;
    public GameObject redGhost;

    void Start()
    {
        rand = Random.Range(1, 4);
        Debug.Log(rand);
        switch(rand)
        {
            case 1: blueGhost.SetActive(true);
                break;
            case 2:
               redGhost.SetActive(true);
                break;
            case 3:
               yellowGhost.SetActive(true);
                break;
            default:
                blueGhost.SetActive(true);
                    break;
        }
    }

}
