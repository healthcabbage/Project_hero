using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static Coin instance;
    public float coin;
    public TotalData data;
    public float keepcoin;

    //싱글턴으로 만들기
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin(float num)
    {
        keepcoin = coin;
        coin += num;
    }

    public void TotalCoin(float num)
    {
        num = data.total_Coin;
    }
    
    public void MinusCoin(float num)
    {
        coin -= num;

        data.total_Coin = coin;
    }
}
