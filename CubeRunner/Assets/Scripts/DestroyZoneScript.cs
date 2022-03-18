using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyZoneScript : MonoBehaviour
{
    [SerializeField] Transform spawnPointPosition;
    private Vector3 currentDestroyZone;

    public int DestroyDistance;
    public InputField inputeDestroyDistance;


    private void Start()
    {
        currentDestroyZone = spawnPointPosition.position + new Vector3(0, 0, DestroyDistance); //отсчитываем расстояние от начала дистанции
        transform.position = currentDestroyZone;                                               //присваиваем Зоне данную позицию
        inputeDestroyDistance.text = "20";                                                     //выводим в поле начальное значение расстояния до уничтожения
    }

    private void Update()
    {        
        currentDestroyZone = spawnPointPosition.position + new Vector3(0, 0, DestroyDistance); //динамическое изменение позиции Зоны Отчуждения)       
        if (currentDestroyZone != transform.position)
        {
            transform.position = currentDestroyZone;
        }
    }

    /// <summary>
    /// Уничтожение всех кубов при сопрокосновении с зоной
    /// </summary>
    /// <param name="objects"></param>
    void OnCollisionEnter(Collision objects)
    {
        if (objects.gameObject.tag == "Player")
        {
            Destroy(objects.gameObject);
        }
    }

    /// <summary>
    /// Ввод расстояния до зоны уничтожения
    /// </summary>
    public void DestroyDistanceInpute()
    {
        if (inputeDestroyDistance.text == "") Debug.Log("Введите число!");
        else DestroyDistance = int.Parse(inputeDestroyDistance.text);
    }

}
