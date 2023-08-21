using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowPlayerData : MonoBehaviour
{
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

    void Awake()
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

        Jobname.text = data.JobName;
        JobPersonal.text = data.jobPersonal;
        Skillname.text = data.skillname;
        Skillpersonal.text = data.skillPersonal;
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
}
