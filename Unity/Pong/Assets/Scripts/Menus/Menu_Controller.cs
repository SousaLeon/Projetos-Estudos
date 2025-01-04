using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{
    public GameObject GameMenu;
    public GameObject OptionsMenu;

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
    public void StartGameMapa_1()
    {
        SceneManager.LoadScene("Stadium_Field");
    }
    public void StartGameMapa_2()
    {
        SceneManager.LoadScene("Stadium_Street");
    }
    #endregion
}