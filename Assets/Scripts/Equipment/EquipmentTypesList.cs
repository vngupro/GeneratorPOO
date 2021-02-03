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
    ShoulderPad,
    Plastron,
    Pants,
    Boots,
    Gloves,
    Belt,
    Shield                                                      //7
}

public enum MaterialType
{
    Bronze,                                                     //0
    Silver,
    Gold,
    Platinium,
    Orihalcon,
    Mithril,
    Adamantium                                                  //6
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

public enum RarityType
{
    Broken,                                                     //0
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary                                                   //5
}