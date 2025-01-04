using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class Stadium_Field_UI : MonoBehaviour
{
    float Pontuacao_P1;
    float Pontuacao_P2;

    public TMP_Text Pont_P1;
    public TMP_Text Pont_P2;
    public GameObject ScreenEndGame;
    public GameObject Win_P1;
    public GameObject Win_P2;
    public Light2D SpotLight_1;
    public Light2D SpotLight_2;
    public Light2D SpotLight_3;
    public Light2D SpotLight_4;
    public Light2D GlobalLight;

    public float _Ponto_P1 { get => Pontuacao_P1; set => Pontuacao_P1 = value; }
    public float _Ponto_P2 { get => Pontuacao_P2; set => Pontuacao_P2 = value; }
    public bool EndGame {  get; private set; }

    public static Stadium_Field_UI SF_UI;
    void Start()
    {
        SF_UI = this;
    }
    void Update() 
    {
        Pont_P1.text = Pontuacao_P1.ToString(); 
        Pont_P2.text = Pontuacao_P2.ToString();
        
        if (Pontuacao_P1 == 2)
        {
            EndGame = true;
            ScreenEndGame.SetActive(true);
            Win_P1.SetActive(true);
            SpotLight_1.intensity = 0.5f;
            SpotLight_2.intensity = 0.5f;
            SpotLight_3.intensity = 0.5f;
            SpotLight_4.intensity = 0.5f;
            GlobalLight.intensity = 0.1f;
        }
        if (Pontuacao_P2 == 2)
        {
            EndGame = true;
            ScreenEndGame.SetActive(true);
            Win_P2.SetActive(true);
            SpotLight_1.intensity = 0.5f;
            SpotLight_2.intensity = 0.5f;
            SpotLight_3.intensity = 0.5f;
            SpotLight_4.intensity = 0.5f;
            GlobalLight.intensity = 0.1f;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Stadium_Field");
    }
    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
