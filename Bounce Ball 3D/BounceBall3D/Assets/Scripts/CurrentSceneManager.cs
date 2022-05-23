using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentSceneManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public Transform startPoint;

    void Start()
    {
        player.transform.position = startPoint.position;
    }

   
}
