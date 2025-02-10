
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject OptionsMenu;
    public GameObject StartGameMenu;

    #region StartMenu
    public void StartGame()
    {
        SceneManager.LoadScene("Mode_1");
    }
    public void OpenStartGame()
    {
        StartGameMenu.SetActive(true);
    }
    public void CloseStartGame()
    {
        StartGameMenu.SetActive(false);
    }
    #endregion
    #region OPTIONS
    public void OpenOptions()
    {
        OptionsMenu.SetActive(true);
    }
    public void CloseOptions()
    {
        OptionsMenu.SetActive(false);
    }
    #endregion
    public void CloseGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
