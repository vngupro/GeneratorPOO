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
    NONE,
    SLASH,          //Bleed chance mandatory
    BLUNT,          //Stun chance mandatory
    PIERCE         //Ignore Defense (pc of physical damage)
}
public enum AilmentType
{
    NONE,
    BURN,
    FREEZE,
    STUN,
    POISON,
    BLEED
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
    SWORD,
    AXE,
    SPEAR,
    MACE,
    HAMMER,
    DAGGERS,
    BOW,
    SCEPTER,
    STAFF,
    TOME
}

public enum ArmorType
{
    HELMET,
    SHOULDER,
    CHESTARMOR,
    PANTS,
    BOOTS,
    GLOVES,
    BELT,
    SHIELD
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

public enum DamageType
{
    PHYSICAL,
    MAGICAL
}

public enum ResistanceType
{
    NONE,
    PHYSICAL,
    MAGICAL,  
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