using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void moveStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void moveSelect()
    {
        SceneManager.LoadScene("Select");
    }

    public void moveStage()
    {
        SceneManager.LoadScene("Stage");
    }

    public void moveShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
