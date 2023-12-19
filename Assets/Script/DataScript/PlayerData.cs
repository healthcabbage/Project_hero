using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Scriptble Object/PlayerData")]
public class PlayerData : ScriptableObject
{
    public enum PlayerType { Knight, Thief, Wizard, Ach, Priest, Bard, Angel, Devil }

    [Header("# Player Job")]
    public PlayerType playertype;
    public int playerid;
    public string JobName;
    [TextArea]
    public string jobPersonal;
    public Sprite JobIcon;

    [Header("# Player Show Base Data")]
    public int hp;
    public int atk;
    public int speed;
    public int critical;

    [Header("# Game Data Set")]
    public RuntimeAnimatorController anim;
    public Sprite ch_image;

    [Header("# Shop Upgrade Data")]
    public int shop_hp;
    public int shop_atk;
    public int shop_speed;
    public int shop_critical;
    public int specialcooltime;
    public int expplus;
    public int coinplus;
    public int itemdragrage;
    public int shopmaking;
    public int rerole;

    [Header("# Shop Gacha Data")]
    public bool isActive;

    [Header("# show start skill")]
    public Sprite skillIcon;
    public string skillname;
    public Sprite Specialskillicon;
    public string Specialskillname;
    [TextArea]
    public string skillPersonal;
    [TextArea]
    public string SpecialSkillPersonal;
}
