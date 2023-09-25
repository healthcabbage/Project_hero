using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public PlayerData[] datas;

    public PlayerData data;

    public int hpupcount;

    int datanum;

    public void select_data(int num)
    {
        switch(num)
        {
            case 0:
                data = datas[0];
                datanum = num;
                break;
            case 1:
                data = datas[1];
                datanum = num;
                break;
            case 2:
                data = datas[2];
                datanum = num;
                break;
            case 3:
                data = datas[3];
                datanum = num;
                break;
            case 4:
                data = datas[4];
                datanum = num;
                break;
            case 5:
                data = datas[5];
                datanum = num;
                break;
            case 6:
                data = datas[6];
                datanum = num;
                break;
            case 7:
                data = datas[7];
                datanum = num;
                break;
        }
    }

    public void hpUp()
    {
        switch(hpupcount)
        {
            case 0:
                ++hpupcount;
                data.hp = data.hp + 4;
                break;
        }
    }
}
