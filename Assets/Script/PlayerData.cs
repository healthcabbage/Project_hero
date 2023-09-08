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
    public int atk;
    public float speed;
    public float critical;
    public RuntimeAnimatorController anim;
    //shop���� �̱�� ��ԵǸ� Ȱ��ȭ�Ǽ� ���̰� �ϱ�
    //���� ������� �ʾ� �����͸� �߰�
    public bool isActive;
    [Header("# shop show data")]
    public int specialcooltime;
    public int expplus;
    public int coinplus;
    public int itemdragrage;
    public int shopmaking;
    public int weaponspeed;

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
