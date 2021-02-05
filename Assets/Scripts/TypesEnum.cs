using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//EQUIPEMENT
public enum AttributeType
{
    FIRE,                                                       //0
    ICE,
    LIGHTNING,
    POISON,
    ACID                                                        //4
}

public enum SubDamageType
{                                                       
    SLASH,         //Bleed chance mandatory                     //0
    BLUNT,         //Stun chance mandatory
    PIERCE         //Ignore Defense (pc of physical damage)     //2
}
public enum AilmentType
{                                
    BURN,                                                        //0
    FREEZE,
    STUN,
    POISON,
    BLEED                                                        //4
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
    Sword,                                                      //0
    Axe,
    Spear,
    Mace,
    Hammer,
    Daggers,
    Bow,
    Scepter,
    Staff,
    Tome                                                        //9
}

public enum ArmorType
{
    Helmet,                                                     //0
    Shoulder,
    Plastron,
    Pants,
    Boots,
    Gloves,
    Belt,
    Cape,
    Shield                                                      //8
}

public enum MaterialType
{
    Bronze,                                                     //0
    Silver,
    Gold,
    Platinum,
    Mithril,
    Orihalcon,
    Adamantium                                                  //6
}

public enum ResistanceType
{                                                       
    PHYSICAL,                                                  //0
    ATTRIBUTE,
    AILMENT,
    FIRE,
    ICE,
    LIGHTNING,
    POISON,
    ACID,
    SLASH,
    PIERCE,
    BLUNT                                                      //10
}

public enum RarityType
{
    Broken,                                                     //0
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary                                                   //5
}

//ITEM
public enum ItemTypes{
    NONE,
    WEAPON,
    ARMOR,
    BONUS,
    MALUS
}
