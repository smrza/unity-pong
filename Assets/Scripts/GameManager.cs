using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameManagerData gameManagerData;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManagerData.MenuCanvas.activeSelf && Input.GetKeyDown(gameManagerData.MenuKey))
        {
            Time.timeScale = 0;
            gameManagerData.IsPaused = !gameManagerData.IsPaused;
            gameManagerData.MenuCanvas.SetActive(gameManagerData.IsPaused);
        }
    }

    public void IncreasePlayer1Score(int points)
    {
        gameManagerData.Player1Score += points;

        if(gameManagerData.Player1Text != null)
        {
            gameManagerData.Player1Text.text = gameManagerData.Player1String + gameManagerData.Player1Score;
        }
    }

    public void IncreasePlayer2Score(int points)
    {
        gameManagerData.Player2Score += points;

        if (gameManagerData.Player2Text != null)
        {
            gameManagerData.Player2Text.text = gameManagerData.Player2String + gameManagerData.Player2Score;
        }
    }

    public void StartButton()
    {
        Time.timeScale = 1;
        gameManagerData.IsPaused = false;
        gameManagerData.MenuCanvas.SetActive(gameManagerData.IsPaused);
    }

    public void Exit()
    {
        Debug.Log("Application Exit");
        Application.Quit();
    }
}
