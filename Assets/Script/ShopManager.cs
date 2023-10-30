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
                sayText.text = "어서와요.\n새로운 운명을 찾을 건가요?\n아님 운명을 개척해 나아가고 싶나요?";
                playText(sayText);
                break;
            case 1:
                sayText.text = "당신이 원하는 운명을 찾길 기원할게요.";
                playText(sayText);
                break;
            case 2:
                sayText.text = "좋아요. 별의 가호가 함께하기를...";
                playText(sayText);
                break;
            case 3:
                sayText.text = "코인이 부족한 것 같네요.";
                playText(sayText);
                break;
            case 4:
                sayText.text = "운명의 힘을 강하게 이끄는 것도 나쁘지않은 선택이죠.";
                playText(sayText);
                break;
            case 5:
                sayText.text = "그것이 당신이 선택한 운명인가요?";
                playText(sayText);
                break;
            case 6:
                sayText.text = "좋아요. 간단한 일이에요.";
                playText(sayText);
                break;
            case 7:
                sayText.text = "코인이 부족한 것 같네요.";
                playText(sayText);
                break;
            case 8:
                sayText.text = "신중한 것도 나쁘지않죠.";
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
        sayName.text = "점성술사";
    }
}
