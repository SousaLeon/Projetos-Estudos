using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public int HighScore { get; set; }
    public TMP_Text HighScorePoint;
    public TMP_Text HighScorePointInGame;
    public GameObject ScreenEndGame;
    public bool EndGame { get; private set; }

    public static GameController GC;
    void Awake()
    {
        GC = this;
    }
    void Update()
    {
        ResetGame();
    }
    void ResetGame()
    {
        if (Ball.ball.QuantObject <= 0)
        {
            ScreenEndGame.SetActive(true);
            EndGame = true;
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Mode_1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
