using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttributeType
{
    NONE,                                                        //0
    FIRE,
    ICE,
    LIGHTNING,
    POISON,
    ACID                                                         //5

}

public enum SubDamageType
{
    NONE,                                                       //0
    SLASH,         //Bleed chance mandatory
    BLUNT,         //Stun chance mandatory
    PIERCE         //Ignore Defense (pc of physical damage)     //3
}
public enum AilmentType
{
    NONE,                                                        //0
    BURN,
    FREEZE,
    STUN,
    POISON,
    BLEED                                                        //5
}

public enum StatType
{
    NONE,                                                       //0
    STRENGTH,
    VITALITY,
    DEXTERITY,
    INTELLIGENCE,
    LUCK                                                        //5
}

public enum WeaponType
{
    SWORD,                                                      //0
    AXE,
    SPEAR,
    MACE,
    HAMMER,
    DAGGERS,
    BOW,
    SCEPTER,
    STAFF,
    TOME                                                        //9
}

public enum ArmorType
{
    HELMET,                                                     //0
    SHOULDER,
    CHESTARMOR,
    PANTS,
    BOOTS,
    GLOVES,
    BELT,
    SHIELD                                                      //7
}

public enum MaterialType
{
    COTON,                                                      //0
    LEATHER,
    BRONZE,
    SILVER,
    GOLD,
    PLATINUM,
    ORIHALCON,
    MITRHIL,
    ADAMANTIUM                                                  //8
}

public enum ResistanceType
{
    NONE,                                                       //0
    PHYSICAL,
    FIRE,
    ICE,
    LIGHTNING,
    POISON,
    ACID,
    SLASH,
    PIERCE,
    BLUNT,
    ELEMENTAL,
    AILMENT                                                     //11
}