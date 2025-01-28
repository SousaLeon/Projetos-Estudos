using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour
{
    float timecount;
    float Pontuacao_P1;
    float Pontuacao_P2;
    int Index;

    public TMP_Text Pont_P1;
    public TMP_Text Pont_P2;
    public GameObject ScreenEndGame;
    public GameObject Win_P1;
    public GameObject Win_P2;
    public GameObject Particle_Rain;
    public Light2D SpotLight_1;
    public Light2D SpotLight_2;
    public Light2D SpotLight_3;
    public Light2D SpotLight_4;
    public Light2D PedestrialSignal_1;
    public Light2D PedestrialSignal_2;
    public Light2D GlobalLight;

    public float _Ponto_P1 { get => Pontuacao_P1; set => Pontuacao_P1 = value; }
    public float _Ponto_P2 { get => Pontuacao_P2; set => Pontuacao_P2 = value; }
    public bool EndGame {  get; private set; }

    public static UI_Controller _Controller;
    void Awake()
    {
        _Controller = this;
    }
    void Start()
    {
        Index = SceneManager.GetActiveScene().buildIndex;
        if (Index == 1)
        {
            ActiveEffectField();
        }
        if (Index == 2)
        {
            ActiveEffectStreet();
        }
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
        if (Game_Mode_Controller.Noite)
        {
            PedestrialSignal_Blink();
        }
    }
    void ActiveEffectField()
    {
        if (Game_Mode_Controller.Chuva)
        {
            Particle_Rain.SetActive(true);
        }
    }
    void ActiveEffectStreet()
    {
        if (Game_Mode_Controller.Dia)
        {
            GlobalLight.intensity = 1f;
            SpotLight_1.intensity = 0;
            SpotLight_2.intensity = 0;
            SpotLight_3.intensity = 0;
            SpotLight_4.intensity = 0;
        }
        else if(Game_Mode_Controller.Noite)
        {
            GlobalLight.intensity = 0.1f;
            SpotLight_1.intensity = 1;
            SpotLight_2.intensity = 1;
            SpotLight_3.intensity = 1;
            SpotLight_4.intensity = 1;
        }
    }
    void PedestrialSignal_Blink()
    {
        timecount += Time.deltaTime;
        if (timecount >= 1f)
        {
            PedestrialSignal_1.color = Color.red;
            PedestrialSignal_2.color = Color.red;
            PedestrialSignal_1.intensity = 1f;
            PedestrialSignal_2.intensity = 1f;
            
            if (timecount >= 2f)
            {
                PedestrialSignal_1.color = Color.green;
                PedestrialSignal_2.color = Color.green;
            }
            if (timecount >= 3f)
            {
                PedestrialSignal_1.intensity = 0f;
                PedestrialSignal_2.intensity = 0f;
                timecount = 0f;
            }
        }        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(Index);
    }
    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
