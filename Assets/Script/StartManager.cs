using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public GameObject setting;
    public bool issetting = false;

    public void MoveSelect()
    {
        SceneManager.LoadScene("Select");
    }

    public void MoveShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void MoveAch()
    {
        //업적 씬이 추가되면 주석제거
    }

    public void Setting()
    {
        if (!issetting)
        {
            setting.SetActive(true);
            issetting = true;
        }
        else
        {
            setting.SetActive(false);
            issetting = false;
        }
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif  
    }
}
