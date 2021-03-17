using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SenceLoader : MonoBehaviour
{
    public void ReloadGame()
    {
        SceneManager.LoadScene("SandBox");
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
