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

    Image playerimage;
    Image skillimage;

    public GameObject view;

    void Awake()
    {
        playerimage = GetComponentsInChildren<Image>()[0];
        playerimage.sprite = data.JobIcon;

        skillimage = GetComponentsInChildren<Image>()[1];
        skillimage.sprite = data.skillIcon;

        TMP_Text[] texts = GetComponentsInChildren<TMP_Text>();
        Jobname = texts[0];
        JobPersonal = texts[1];
        Skillname = texts[2];
        Skillpersonal = texts[3];

        Jobname.text = data.JobName;
        JobPersonal.text = data.jobPersonal;
        Skillname.text = data.skillname;
        Skillpersonal.text = data.skillPersonal;
    }

    public void Viewdata()
    {
        view.SetActive(true);
    }

    public void CheckId()
    {
        PlayerPrefs.SetInt("JobID", data.playerid);
    }
}
