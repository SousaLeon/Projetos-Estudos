using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int EnemyAmount { get; set; } = 30;
    public bool EndGame { get; set; }

    public GameObject Winner;
    public GameObject Loser;
    public GameObject EndGameScreen;

    public static GameController GC;

    void Awake()
    {
        GC = this;
    }

    void Update()
    {
        MoreVelocityEnemy();

        if (EnemyAmount == 0)
        {
            EndGame = true;
            EndGameScreen.SetActive(true);
            Winner.SetActive(true);
        }
    }
    void MoreVelocityEnemy()
    {
        switch (EnemyAmount)
        {
            case 20:
                if (Yellow_Enemy.YE.Velocity > 0 && Blue_Enemy.BE.Velocity > 0 && Red_Enemy.RE.Velocity > 0)
                {
                    Red_Enemy.RE.Velocity = 0.4f;
                    Blue_Enemy.BE.Velocity = 0.3f;
                    Yellow_Enemy.YE.Velocity = 0.2f;
                }
                else
                {
                    Red_Enemy.RE.Velocity = -0.4f;
                    Blue_Enemy.BE.Velocity = -0.3f;
                    Yellow_Enemy.YE.Velocity = -0.2f;
                }                
                break;
            case 12:
                if (Yellow_Enemy.YE.Velocity > 0 && Blue_Enemy.BE.Velocity > 0 && Red_Enemy.RE.Velocity > 0)
                {
                    Red_Enemy.RE.Velocity = 0.5f;
                    Blue_Enemy.BE.Velocity = 0.4f;
                    Yellow_Enemy.YE.Velocity = 0.3f;
                }
                else
                {
                    Red_Enemy.RE.Velocity = -0.5f;
                    Blue_Enemy.BE.Velocity = -0.4f;
                    Yellow_Enemy.YE.Velocity = -0.3f;
                }                
                break;
            case 5:
                if (Yellow_Enemy.YE.Velocity > 0 && Blue_Enemy.BE.Velocity > 0 && Red_Enemy.RE.Velocity > 0)
                {
                    Red_Enemy.RE.Velocity = 0.7f;
                    Blue_Enemy.BE.Velocity = 0.6f;
                    Yellow_Enemy.YE.Velocity = 0.5f;
                }
                else
                {
                    Red_Enemy.RE.Velocity = -0.7f;
                    Blue_Enemy.BE.Velocity = -0.6f;
                    Yellow_Enemy.YE.Velocity = -0.5f;
                }                
                break;
            case 3:
                if (Yellow_Enemy.YE.Velocity > 0 && Blue_Enemy.BE.Velocity > 0 && Red_Enemy.RE.Velocity > 0)
                {
                    Red_Enemy.RE.Velocity = 0.9f;
                    Blue_Enemy.BE.Velocity = 0.8f;
                    Yellow_Enemy.YE.Velocity = 0.7f;
                }
                else
                {
                    Red_Enemy.RE.Velocity = -0.9f;
                    Blue_Enemy.BE.Velocity = -0.8f;
                    Yellow_Enemy.YE.Velocity = -0.7f;
                }                
                break;
        }
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Restart()
    {
        //Atualizar forma de carregar quando criar novos modos.
        SceneManager.LoadScene("Mode_1");
    }
}