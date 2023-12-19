using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "total", menuName = "Scriptble Object/totalData")]
public class TotalData : ScriptableObject
{
    [Header("# Total Coin")]
    public float total_Coin;

    [Header("# Player Upgrade")]
    public int[] hp_up;
    public int[] atk_up;
    public int[] speed_up;
    public int[] critical_up;
    public int[] spskill_up;
    public int[] exp_up;
    public int[] shopmaking_up;
    public int[] coin_up;
    public int[] itemdrage_up;
    public int[] leveluprerole_up;

    [Header("# Upgrade coin")]
    public int[] hp_coin;
    public int[] atk_coin;
    public int[] speed_coin;
    public int[] critical_coin;
    public int[] spskill_coin;
    public int[] exp_coin;
    public int[] shop_coin;
    public int[] coin_coin;
    public int[] item_coin;
    public int[] leveluprerole_coin;
}
