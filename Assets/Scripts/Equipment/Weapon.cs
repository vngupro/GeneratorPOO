using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Equipment
{
    int minDamage = 0;
    int maxDamage = 0;
    float atkPerSec = .0f;
    bool isTwoHanded = false;
    float criticalChance = .0f;
    float criticalDamage = .0f;
    DamageType damageType;
    List<Ailment> ailmentDamageList = new List<Ailment>();
    List<Attribute> attributeDamageList = new List<Attribute>();
    List<SubDamage> SubDamageList = new List<SubDamage>();
}
