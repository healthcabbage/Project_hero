using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Scriptble Object/WeaponData")]
public class WeaponData : ScriptableObject
{
    public enum WeaponType { KnightSword, Thiefdagger, ArchBow, WizardOrb, PriestBook, BardHarp, AngelRapier, Demonwhip,  }

    [Header("# Main")]
    public WeaponType weapontype;
    public int weaponId;
    public string weaponname;
    [TextArea]
    public string weaponDesc;
    public Sprite weaponIcon;

    [Header("# Level Data")]
    public float baseDamage;
    public int baseCount;
    public float speed;
    public float[] damages; //공격력 추가
    public int[] counts; //무기 추가
    public float[] speeds; //무기 공격 속도

    [Header("# Weapon")]
    public GameObject projectile;
    public Sprite hand;
}
