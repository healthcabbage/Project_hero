using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowPlayerData : MonoBehaviour
{
    public PlayerData[] datas;

    public PlayerData data;

    TMP_Text Jobname;
    TMP_Text JobPersonal;
    TMP_Text Skillname;
    TMP_Text Skillpersonal;
    TMP_Text SpecialSkill;
    TMP_Text SpecialSkillpersonal;

    Image playerimage;
    Image skillimage;
    Image SpecialSkillimage;

    public GameObject view;

    private void OnEnable()
    {
        playerimage = GetComponentsInChildren<Image>()[2];
        playerimage.sprite = data.JobIcon;

        skillimage = GetComponentsInChildren<Image>()[5];
        skillimage.sprite = data.skillIcon;

        SpecialSkillimage = GetComponentsInChildren<Image>()[7];
        SpecialSkillimage.sprite = data.Specialskillicon;

        TMP_Text[] texts = GetComponentsInChildren<TMP_Text>();
        Jobname = texts[0];
        JobPersonal = texts[1];
        Skillname = texts[3];
        Skillpersonal = texts[4];
        SpecialSkill = texts[6];
        SpecialSkillpersonal = texts[7];

        Jobname.text = data.JobName;
        JobPersonal.text = string.Format(data.jobPersonal, data.hp, data.atk, data.speed, data.critical * 100);
        Skillname.text = data.skillname;
        Skillpersonal.text = data.skillPersonal;
        SpecialSkill.text = data.Specialskillname;
        SpecialSkillpersonal.text = data.SpecialSkillPersonal;
    }

    public void CheckId()
    {
        PlayerPrefs.SetInt("JobID", data.playerid);
    }

    public void HideDate()
    {
        if (view.activeSelf == true)
        {
            view.SetActive(false);
        }
    }

    public void selectdata(int num)
    {
        switch(num)
        {
            case 0:
                data = datas[0];
                break;
            case 1:
                data = datas[1];
                break;
            case 2:
                data = datas[2];
                break;
            case 3:
                data = datas[3];
                break;
            case 4:
                data = datas[4];
                break;
            case 5:
                data = datas[5];
                break;
            case 6:
                data = datas[6];
                break;
            case 7:
                data = datas[7];
                break;
        }
    }
}
