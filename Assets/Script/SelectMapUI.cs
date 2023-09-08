using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMapUI : MonoBehaviour
{
    public Sprite[] selectmap;

    public int stagenum;

    public Button select;

    void Start()
    {
        select = GetComponentsInChildren<Button>()[0];
        stagenum = 0;
        select.image.sprite = selectmap[stagenum];
    }

    public void pluschangestage()
    {
        switch(stagenum)
        {
            case 0:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 1:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 2:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 3:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 4:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 5:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 6:
                stagenum = ++stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 7:
                stagenum = 0;
                select.image.sprite = selectmap[stagenum];
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
                break;
            case 1:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 2:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 3:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 4:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 5:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 6:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
            case 7:
                stagenum = --stagenum;
                select.image.sprite = selectmap[stagenum];
                break;
        }
    }
}
