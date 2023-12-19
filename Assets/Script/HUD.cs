using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
    public enum InfoType { Exp, Level, Kill, Time, Health, HealthText, SpSkill, Icon, Dead_Time, Dead_Kill, Dead_Coin, Coin }
    public InfoType type;

    TMP_Text myText;
    Slider mySlider;
    Image myicon;

    int num;

     void Awake()
    {
        myText = GetComponent<TMP_Text>();
        mySlider = GetComponent<Slider>();
        myicon = GetComponent<Image>();
        PlayerPrefs.GetInt("JobID", num);
    }

    //캐릭터 아이콘 작업
    private void Start()
    {
        //switch(type)
        {

        }

        switch (type)
        {
            case InfoType.Dead_Time:
                StartCoroutine(Count(GameManager.instance.gameTime, 0));
                break;
            case InfoType.Dead_Kill:
                StartCoroutine(Count(GameManager.instance.kill, 0));
                break;
            case InfoType.Dead_Coin:
                StartCoroutine(Count(Coin.instance.coin, 0));
                break;
        }
    }

    //spskill 연동 작업
    void LateUpdate()
    {
        switch(type)
        {
            case InfoType.Exp:
                float curExp = GameManager.instance.exp;
                float maxExp = GameManager.instance.nextExp[Mathf.Min(GameManager.instance.level, GameManager.instance.nextExp.Length - 1)];
                mySlider.value = curExp / maxExp;
                break;
            case InfoType.Level:
                myText.text = string.Format("Lv.{0:F0}",GameManager.instance.level);
                break;
            case InfoType.Kill:
                myText.text = string.Format("{0:F0}", GameManager.instance.kill);
                break;
            case InfoType.Time:
                //float remainTime = GameManager.instance.maxGameTime - GameManager.instance.gameTime;
                float remainTime = GameManager.instance.gameTime;
                int min = Mathf.FloorToInt(remainTime / 60);
                int sec = Mathf.FloorToInt(remainTime % 60);
                myText.text = string.Format("{0:D2}:{1:D2}", min, sec);
                break;
            case InfoType.Health:
                float curHealth = GameManager.instance.health;
                float maxHealth = GameManager.instance.maxhealth;
                mySlider.value = curHealth / maxHealth;
                break;
            case InfoType.HealthText:
                float curhealth = GameManager.instance.health;
                float maxhealth = GameManager.instance.maxhealth;
                myText.text = string.Format("{0:F0}/{1:F0}", curhealth, maxhealth);
                break;
            case InfoType.SpSkill:
                float curSpskill = GameManager.instance.Sp;
                float maxSpskill = GameManager.instance.maxSep;
                mySlider.value = curSpskill / maxSpskill;
                break;
        }
    }

    //코인 올라가는 애니메이션
    IEnumerator Count(float target, float current)
    {
        float duration = 0.5f;
        float offset = (target - current) / duration;
        Debug.Log(offset);

        yield return new WaitForSecondsRealtime(3f);

        while (current < target)
        {
            current += offset * Time.unscaledDeltaTime;
            myText.text = ((int)current).ToString();
            yield return new WaitForSecondsRealtime(0.01f);
        }

        current = target;
        myText.text = ((int)current).ToString();
    }
}
