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
    public RuntimeAnimatorController anim;
    //shop에서 뽑기로 얻게되면 활성화되서 보이게 하기
    //아직 연결되지 않아 데이터만 추가
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
