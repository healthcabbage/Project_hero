using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coin;
    public TotalData data;

    public void AddCoin(int num)
    {
        coin += num;

        data.total_Coin = coin;
    }

    public void TotalCoin(int num)
    {
        num = data.total_Coin;
    }
    
    public void MinusCoin(int num)
    {
        coin -= num;

        data.total_Coin = coin;
    }
}
