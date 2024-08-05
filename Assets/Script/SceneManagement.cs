using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    public void loginScreen()
    {
        Application.OpenURL("LoginScreen");
    }

    public void helloScreen()
    {
        SceneManager.LoadScene("HelloScene");
    }

    public void arScene()
    {
        SceneManager.LoadScene("ModelTarget");
    }

    public void arSceneBiru()
    {
        SceneManager.LoadScene("ModelTarget2");
    }

    public void userHomeScene()
    {
        SceneManager.LoadScene("UserHomeScene");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
