using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectManager : MonoBehaviour
{
    public GameObject SelectView;
    bool hideselect = false;

    public void MoveStage()
    {
        SceneManager.LoadScene("Stage");
    }

    public void MoveStage2()
    {
        //���� �÷��� ������ �Ѿ��
    }

    public void ShowSelect()
    {
        if (hideselect != true)
        {
            hideselect = true;
            SelectView.SetActive(true);
        }
        else
        {
            hideselect = false;
            SelectView.SetActive(false);
        }
    }
}
