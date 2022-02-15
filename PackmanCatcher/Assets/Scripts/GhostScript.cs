using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GhostScript : MonoBehaviour
{
    bool MousePushed = false;

    public Text scoreText;
    public GameObject restartPanel;

    private int score;

    private void Start()
    {
        scoreText.text = "1";
    }
    void Update()
    {
        Vector2 cursorPosition = Input.mousePosition;                       //считывает позицию курсора 

        cursorPosition = Camera.main.ScreenToWorldPoint(cursorPosition);    //ограничивает позицию курсора полями камеры

        if (MousePushed) transform.position = cursorPosition;

        scoreText.text = score.ToString();

        if(score == 5)
        {
            restartPanel.SetActive(true);
        }
    }


    /// <summary>
    /// Зажал кнопку мыши
    /// </summary>
    public void OnMouseDown()
    {
       
        MousePushed = true;
        
    }

    /// <summary>
    /// Отпустил кнопку мыши
    /// </summary>
    public void OnMouseUp()
    {
        
        MousePushed = false;
    }

    /// <summary>
    /// Срабатывает триггер при соприкосновении призрака и пакмана
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        other.gameObject.SetActive(false);
    }
    /// <summary>
    /// Перезапуск сцены
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    /// <summary>
    /// Выход из игры
    /// </summary>
    public void exitButtonPressed()
    {
        Application.Quit();
    }


}
