using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] InputField playerNameInput;
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void SetPlayerName()
    {
        PlayerDataHandle.Instance.PlayerName = playerNameInput.text;
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
    }

}
