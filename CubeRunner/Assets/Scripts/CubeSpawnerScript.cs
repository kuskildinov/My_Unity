using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawnerScript : MonoBehaviour
{
    public CubeMoveScript cubePrefab;  
    public float spawnTime;
    public int cubeSpeed;
    public Transform finishPoint;

    public InputField inputeSpeed;    
    public InputField inputeSpawnTime;

    private float timer;

    void Start()
    {
        timer = spawnTime;
        inputeSpeed.text = "1";
        inputeSpawnTime.text = "2";
    }
    
    void Update()
    {        
        timer -= Time.deltaTime;
        cubePrefab.finishPoint = finishPoint;
        cubePrefab.speed = cubeSpeed;

        //Спавн кубика после окончания таймера
        if (timer <= 0)
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity); 
            timer = spawnTime;
        }       
    }   

    /// <summary>
    /// Ввод скорости через поле
    /// </summary>
    public void SpeedInput()
    {
        if (inputeSpeed.text == "") Debug.Log("Введите число!");
        else cubeSpeed = int.Parse(inputeSpeed.text);
    }

    /// <summary>
    /// Ввод времени спавна кубов
    /// </summary>
    public void SpawnTimeInpute()
    {
        if (inputeSpawnTime.text == "") Debug.Log("Введите число!");
        else spawnTime = int.Parse(inputeSpawnTime.text);
    }

}
