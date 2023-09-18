using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectMapUI : MonoBehaviour
{
    public Sprite[] selectmap;

    public int stagenum;

    public Button select;

    public TMP_Text stagename;

    void Start()
    {
        select = GetComponentsInChildren<Button>()[0];
        stagenum = 0;
        select.image.sprite = selectmap[stagenum];

        TMP_Text text = GetComponentInChildren<TMP_Text>();
        stagename = text;
        stagename.text = "����";
    }

    public void pluschangestage()
    {
        switch(stagenum)
        {
            case 0:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "����";
                break;
            case 1:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "�������� ž";
                break;
            case 2:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "���� ��";
                break;
            case 3:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "����";
                break;
            case 4:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "�غ�";
                break;
            case 5:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "Ÿ���� ����";
                break;
            case 6:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "������ ����";
                break;
            case 7:
                stagenum = 0;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "����";
                break;
        }
    }

    public void minuschangestage()
    {
        switch(stagenum)
        {
            case 0:
                stagenum = 7;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "������ ����";
                break;
            case 1:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "����";
                break;
            case 2:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "����";
                break;
            case 3:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "�������� ž";
                break;
            case 4:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "���� ��";
                break;
            case 5:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "����";
                break;
            case 6:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "�غ�";
                break;
            case 7:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "Ÿ���� ����";
                break;
        }
    }
}
