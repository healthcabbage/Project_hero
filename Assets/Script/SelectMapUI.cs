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
        stagename.text = "들판";
    }

    public void pluschangestage()
    {
        switch(stagenum)
        {
            case 0:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "유적";
                break;
            case 1:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "마법사의 탑";
                break;
            case 2:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "깊은 숲";
                break;
            case 3:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "묘지";
                break;
            case 4:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "해변";
                break;
            case 5:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "타락한 신전";
                break;
            case 6:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "부패한 신전";
                break;
            case 7:
                stagenum = 0;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "들판";
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
                stagename.text = "부패한 신전";
                break;
            case 1:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "들판";
                break;
            case 2:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "유적";
                break;
            case 3:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "마법사의 탑";
                break;
            case 4:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "깊은 숲";
                break;
            case 5:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "묘지";
                break;
            case 6:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "해변";
                break;
            case 7:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                stagename.text = "타락한 신전";
                break;
        }
    }
}
