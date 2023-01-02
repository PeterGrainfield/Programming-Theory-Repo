using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private string userName = "No name";

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void ResetScene()
    {
        StartGame();
    }

    public void SetUserName(string name)
    {
        userName = name;
    }

    public string GetUserName()
    {
        return userName;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
