using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIController : MonoBehaviour
{
    [SerializeField] GameObject Options;
    public void StartGame()
    {
        SceneManager.LoadScene("Mode_1");
    }
    public void OpenOptions()
    {
        Options.SetActive(true);
    }
    public void CloseOptions()
    {
        Options.SetActive(false);
    }
    public void ExitGame()
    {
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}