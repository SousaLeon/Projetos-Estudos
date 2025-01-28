using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using Unity.VisualScripting;

public class Menu_Controller : MonoBehaviour
{
    public GameObject GameMenu;
    public GameObject OptionsMenu;
    public GameObject Controller_Field;
    public GameObject Controller_Street;
    public GameObject Aviso;
    public Toggle Dia;
    public Toggle Noite;
    public Toggle Chuva;
    public Toggle MapaCampo;
    public Toggle MapaRua;

    void Awake()
    {
        MapaCampo.isOn = Game_Mode_Controller.MapaCampo;
        MapaRua.isOn = Game_Mode_Controller.MapaRua;
        Dia.isOn = Game_Mode_Controller.Dia;
    }
    #region OpenMenus
    public void OpenGameMenu()
    {
        GameMenu.SetActive(true);
    }
    public void OpenOptionsMenu()
    {
        OptionsMenu.SetActive(true);
    }
    #endregion
    #region CloseMenus
    public void CloseGameMenu()
    {
        GameMenu.SetActive(false);
    }
    public void CloseOptionsMenu() 
    {
        OptionsMenu.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
    #endregion
    #region CarregarMapas

    public void FieldToggle()
    {
        Game_Mode_Controller.MapaCampo = MapaCampo.isOn;

        if (Game_Mode_Controller.MapaCampo && !Game_Mode_Controller.MapaRua)
        {
            Controller_Field.SetActive(true);
        }
        else
        {
            Controller_Field.SetActive(false);
        }
    }
    public void StreetToggle()
    {
        Game_Mode_Controller.MapaRua = MapaRua.isOn;

        if (Game_Mode_Controller.MapaRua && !Game_Mode_Controller.MapaCampo)
        {
            Controller_Street.SetActive(true);
        }
        else
        {
            Controller_Street.SetActive(false);
        }
    }


    public void StartGameField()
    {
        Game_Mode_Controller.Chuva = Chuva.isOn;

        if (Chuva.isOn)
        {
            SceneManager.LoadScene("Stadium_Field");
        }
        else
        {
            SceneManager.LoadScene("Stadium_Field");
        }
    }
    public void StartGameStreet()
    {
        Game_Mode_Controller.Noite = Noite.isOn;
        Game_Mode_Controller.Dia = Dia.isOn;

        if (Dia.isOn && !Noite.isOn)
        {
            SceneManager.LoadScene("Stadium_Street");
        }
        else if(Noite.isOn && !Dia.isOn)
        {
            SceneManager.LoadScene("Stadium_Street");
        }
        else if (Dia.isOn && Noite.isOn)
        {
            StartCoroutine(AvisoTempo());
        }
    }

    IEnumerator AvisoTempo()
    {
        Aviso.SetActive(true);
        yield return new WaitForSeconds(3f);
        Aviso.SetActive(false);
    }
    #endregion

}