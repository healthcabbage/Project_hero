using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;
using DG.Tweening;

public class ShopManager : MonoBehaviour
{
    public TMP_Text cointext;
    public Coin coin;
    public int coinnum;

    public TMP_Text sayText;
    public TMP_Text sayName;
    public int textspeed;

    public void Start()
    {
        coin.TotalCoin(coinnum);
        cointext.text = coinnum.ToString();
        say(0);
        Name();
    }

    public void say(int num)
    {
        switch(num)
        {
            case 0:
                sayText.text = "��Ϳ�.\n���ο� ����� ã�� �ǰ���?\n�ƴ� ����� ��ô�� ���ư��� �ͳ���?";
                playText(sayText);
                break;
            case 1:
                sayText.text = "����� ���ϴ� ����� ã�� ����ҰԿ�.";
                playText(sayText);
                break;
            case 2:
                sayText.text = "���ƿ�. ���� ��ȣ�� �Բ��ϱ⸦...";
                playText(sayText);
                break;
            case 3:
                sayText.text = "������ ������ �� ���׿�.";
                playText(sayText);
                break;
            case 4:
                sayText.text = "����� ���� ���ϰ� �̲��� �͵� ���������� ��������.";
                playText(sayText);
                break;
            case 5:
                sayText.text = "�װ��� ����� ������ ����ΰ���?";
                playText(sayText);
                break;
            case 6:
                sayText.text = "���ƿ�. ������ ���̿���.";
                playText(sayText);
                break;
            case 7:
                sayText.text = "������ ������ �� ���׿�.";
                playText(sayText);
                break;
            case 8:
                sayText.text = "������ �͵� ����������.";
                playText(sayText);
                break;
        }
    }

    public void playText(TMP_Text text)
    {
        text.maxVisibleCharacters = 0;
        DOTween.To(x => text.maxVisibleCharacters = (int)x, 0f, text.text.Length, textspeed).SetDelay(0.5f);
    }
    
    void Name()
    {
        sayName.text = "��������";
    }
}
