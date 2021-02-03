using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttributeType
{
    NONE,
    FIRE,
    ICE,
    LIGHTNING,
    POISON,
    ACID

}

public enum SubDamageType
{
    NONE,          //0
    SLASH,         //Bleed chance mandatory
    BLUNT,         //Stun chance mandatory
    PIERCE         //3 Ignore Defense (pc of physical damage)
}
public enum AilmentType
{
    NONE,       //0
    BURN,
    FREEZE,
    STUN,
    POISON,
    BLEED       //5
}

public enum StatType
{
    NONE,
    STRENGTH,
    VITALITY,
    DEXTERITY,
    INTELLIGENCE,
    LUCK
}

public enum WeaponType
{
    SWORD,              //0
    AXE,
    SPEAR,
    MACE,
    HAMMER,
    DAGGERS,
    BOW,
    SCEPTER,
    STAFF,
    TOME                //9
}

public enum ArmorType
{
    HELMET,            //0
    SHOULDER,
    CHESTARMOR,
    PANTS,
    BOOTS,
    GLOVES,
    BELT,
    SHIELD            //7
}

public enum MaterialType
{
    COTON,
    LEATHER,
    BRONZE,
    SILVER,
    GOLD,
    PLATINUM,
    ORIHALCON,
    MITRHIL,
    ADAMANTIUM
}

public enum ResistanceType
{
    NONE,
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
    AILMENT
}