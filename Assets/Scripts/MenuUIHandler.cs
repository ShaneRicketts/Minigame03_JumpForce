using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{    
    public void LoadFirstGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSecondGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadThirdGame()
    {
        SceneManager.LoadScene(3);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }

}