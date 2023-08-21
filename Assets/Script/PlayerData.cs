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

    [Header("# Player Data")]
    public int hp;
    public int mp;
    public float speed;
    public float critical;

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
