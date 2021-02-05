using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Equipment
{
    #region Variable
    public WeaponType WeaponType { get; private set; } = WeaponType.Sword;
    public int MinDamage { get; private set; } = 0;
    public int MaxDamage { get; private set; } = 0;
    public bool IsTwoHanded { get; private set; } = false;
    public float AtkPerSec { get; private set; } = .0f;
    public float CriticalChance { get; private set; } = .0f;
    public float CriticalDamage { get; private set; } = .0f;
    #endregion
    #region Lists
    private List<Attribute> attributeList = new List<Attribute>();
    private List<SubDamage> subDamageList = new List<SubDamage>();
    private List<Ailment> ailmentList = new List<Ailment>();
    #endregion
    #region Construtor
    public Weapon()
    {
        this.WeaponType = (WeaponType)(UnityEngine.Random.Range(0, Enum.GetValues(typeof(WeaponType)).Length));
        this.MinDamage = InitDamage();
        this.MaxDamage = this.MinDamage + UnityEngine.Random.Range(1, 100);
        if (this.MaxDamage > 999) this.MaxDamage = 999;
        int rngTwoHanded = UnityEngine.Random.Range(0, 99);
        if (this.WeaponType != WeaponType.Daggers && this.WeaponType != WeaponType.Tome) this.IsTwoHanded = (rngTwoHanded < 50) ? true : false;
        this.AtkPerSec = InitAtkPerSec();
        if (IsTwoHanded) this.AtkPerSec *= UnityEngine.Random.Range(1.1f, 1.5f);
        this.CriticalChance = UnityEngine.Random.Range(0.0f, 100.0f);
        this.CriticalDamage = UnityEngine.Random.Range(10.0f, 200.0f);
        CreateAttributeList();
        CreateSubDamageList();
        CreateAilmentList();
        this.Name = NameGenerator();
    }
    #endregion
    #region Method
    //Create Ailment by choosing in a pool of doNotHave AilmentType
    public Ailment CreateAilment()
    {
        List<AilmentType> alreadyHaveList = new List<AilmentType>();
        List<AilmentType> doNotHaveList = new List<AilmentType>();
        var allTypeArray = Enum.GetValues(typeof(AilmentType));
        Ailment ailment;
        if(ailmentList.Count != 0)
        {
            foreach (Ailment element in ailmentList)
            {
                alreadyHaveList.Add(element.ailmentType);
            }

            foreach (AilmentType elem in allTypeArray)
            {
                bool gotIt = false;
                foreach (AilmentType other in alreadyHaveList)
                {
                    if (elem == other)
                    {
                        gotIt = true;
                    }
                }

                if (!gotIt)
                {
                    doNotHaveList.Add(elem);
                }
            }

            if (doNotHaveList.Count == 0)
            {
                return null;
            }

            ailment = new Ailment(doNotHaveList[UnityEngine.Random.Range(0, doNotHaveList.Count - 1)]);
        }
        else
        {
            ailment = new Ailment();
        }

        return ailment;
    }

    public Ailment CreateAilment(AilmentType type)
    {
        Ailment ailment = new Ailment(type);
        foreach (Ailment element in ailmentList)
        {
            if (ailment.ailmentType == element.ailmentType)
            {
                return null;
            }
        }
        return ailment; 
    }

    // Create Attribute by choosing in a pool of doNotHave AttributeType
    public Attribute CreateAttribute()
    {
        List<AttributeType> alreadyHaveList = new List<AttributeType>();
        List<AttributeType> doNotHaveList = new List<AttributeType>();
        var allTypeArray = Enum.GetValues(typeof(AttributeType));
        Attribute attribute;
        if (attributeList.Count != 0)
        {
            foreach (Attribute element in attributeList)
            {
                alreadyHaveList.Add(element.attributeType);
            }

            foreach (AttributeType elem in allTypeArray)
            {
                bool gotIt = false;
                foreach (AttributeType other in alreadyHaveList)
                {
                    if (elem == other)
                    {
                        gotIt = true;
                    }
                }

                if (!gotIt)
                {
                    doNotHaveList.Add(elem);
                }
            }

            if (doNotHaveList.Count == 0)
            {
                return null;
            }

            attribute = new Attribute(doNotHaveList[UnityEngine.Random.Range(0, doNotHaveList.Count - 1)]);
        }
        else
        {
            attribute = new Attribute();
        }

        return attribute;
    }
    public SubDamage CreateSubDamage(SubDamageType type)
    {
        SubDamage subDamage = new SubDamage(type, this.Rarity, this.MaterialName);
        return subDamage;
    }
    private int NbrAilmentToCreate()
    {
        switch (this.Rarity)
        {
            case RarityType.Broken: return 0;
            case RarityType.Common: return UnityEngine.Random.Range(0, 1);
            case RarityType.Uncommon: return UnityEngine.Random.Range(0, 2);
            case RarityType.Rare: return UnityEngine.Random.Range(1, 2);
            case RarityType.Epic: return UnityEngine.Random.Range(2, 4);
            case RarityType.Legendary: return UnityEngine.Random.Range(3, Enum.GetValues(typeof(AilmentType)).Length);
        }
        return 0;
    }
    private int NbrAttributeToCreate()
    {
        switch (this.Rarity)
        {
            case RarityType.Broken: return 0;
            case RarityType.Common: return UnityEngine.Random.Range(0, 1);
            case RarityType.Uncommon: return UnityEngine.Random.Range(0, 2);
            case RarityType.Rare: return UnityEngine.Random.Range(1, 2);
            case RarityType.Epic: return UnityEngine.Random.Range(2, 4);
            case RarityType.Legendary: return UnityEngine.Random.Range(3, Enum.GetValues(typeof(AttributeType)).Length);
        }
        return 0;
    }
    private void CreateAilmentList()
    {
        foreach (SubDamage subDamage in subDamageList)
        {
            switch (subDamage.subDamageType)
            {
                case SubDamageType.BLUNT:
                    if(CreateAilment(AilmentType.STUN) != null) ailmentList.Add(CreateAilment(AilmentType.STUN));
                    break;
                case SubDamageType.PIERCE:
                    if (CreateAilment(AilmentType.BLEED) != null) ailmentList.Add(CreateAilment(AilmentType.BLEED));
                    break;
                case SubDamageType.SLASH:
                    if (CreateAilment(AilmentType.BLEED) != null) ailmentList.Add(CreateAilment(AilmentType.BLEED));
                    break;
            }
        }

        foreach (Attribute attribute in attributeList)
        {
            switch (attribute.attributeType)
            {
                case AttributeType.ACID:
                    if (CreateAilment(AilmentType.BURN) != null) ailmentList.Add(CreateAilment(AilmentType.BURN));
                    break;
                case AttributeType.FIRE:
                    if (CreateAilment(AilmentType.BURN) != null) ailmentList.Add(CreateAilment(AilmentType.BURN));
                    break;
                case AttributeType.ICE:
                    if (CreateAilment(AilmentType.FREEZE) != null) ailmentList.Add(CreateAilment(AilmentType.FREEZE));
                    break;
                case AttributeType.LIGHTNING:
                    if (CreateAilment(AilmentType.STUN) != null) ailmentList.Add(CreateAilment(AilmentType.STUN));
                    break;
                case AttributeType.POISON:
                    if (CreateAilment(AilmentType.POISON) != null) ailmentList.Add(CreateAilment(AilmentType.POISON));
                    break;
            }
        }

        int nbAilment = NbrAilmentToCreate();
        if (nbAilment == 0) return;
        for (int i = ailmentList.Count; i <= nbAilment; i++)
        {
            ailmentList.Add(CreateAilment());
        }
    }

    private void CreateAttributeList()
    {

        int nbAttribute = NbrAttributeToCreate();
        if (nbAttribute == 0) return;
        for (int i = 0; i < nbAttribute; i++)
        {
            attributeList.Add(CreateAttribute());
        }
    }

    private void CreateSubDamageList()
    {
        int pcSlash = 0;
        int pcBlunt = 0;
        int pcPierce = 0;
        switch (WeaponType)
        {
            case WeaponType.Axe:
                pcSlash = UnityEngine.Random.Range(0, 100);
                pcBlunt = UnityEngine.Random.Range(0, 100);
                pcPierce = UnityEngine.Random.Range(0, 100);
                if (pcSlash < 80) subDamageList.Add(CreateSubDamage(SubDamageType.BLUNT));
                if (pcBlunt < 30) subDamageList.Add(CreateSubDamage(SubDamageType.SLASH));
                if (pcPierce < 50) subDamageList.Add(CreateSubDamage(SubDamageType.PIERCE));
                break;
            case WeaponType.Bow:
                pcPierce = UnityEngine.Random.Range(0, 100);
                if (pcPierce < 50) subDamageList.Add(CreateSubDamage(SubDamageType.PIERCE));
                break;
            case WeaponType.Daggers:
                pcPierce = UnityEngine.Random.Range(0, 100);
                subDamageList.Add(CreateSubDamage(SubDamageType.SLASH));
                if (pcPierce < 50) subDamageList.Add(CreateSubDamage(SubDamageType.PIERCE));
                break;
            case WeaponType.Hammer:
                subDamageList.Add(CreateSubDamage(SubDamageType.BLUNT));
                break;
            case WeaponType.Mace:
                pcPierce = UnityEngine.Random.Range(0, 100);
                subDamageList.Add(CreateSubDamage(SubDamageType.BLUNT));
                if (pcPierce < 30) subDamageList.Add(CreateSubDamage(SubDamageType.PIERCE));
                break;
            case WeaponType.Scepter:
                pcBlunt = UnityEngine.Random.Range(0, 100);
                if (pcBlunt < 30) subDamageList.Add(CreateSubDamage(SubDamageType.BLUNT));
                break;
            case WeaponType.Spear:
                subDamageList.Add(CreateSubDamage(SubDamageType.PIERCE));
                break;
            case WeaponType.Staff:
                pcBlunt = UnityEngine.Random.Range(0, 100);
                if (pcBlunt < 50) subDamageList.Add(CreateSubDamage(SubDamageType.BLUNT));
                break;
            case WeaponType.Sword:
                pcSlash = UnityEngine.Random.Range(0, 100);
                pcPierce = UnityEngine.Random.Range(0, 100);
                break;
            case WeaponType.Tome:
                pcBlunt = UnityEngine.Random.Range(0, 100);
                if (pcBlunt < 10) subDamageList.Add(CreateSubDamage(SubDamageType.BLUNT));
                break;
        }
    }

    private int InitDamage()
    {
        int res = 0;
        switch (this.MaterialName)
        {
            case MaterialType.Bronze:
                res = UnityEngine.Random.Range(1, 100);
                break;
            case MaterialType.Silver:
                res = UnityEngine.Random.Range(1, 200);
                break;
            case MaterialType.Gold:
                res = UnityEngine.Random.Range(5, 300);
                break;
            case MaterialType.Platinum:
                res = UnityEngine.Random.Range(5, 400);
                break;
            case MaterialType.Mithril:
                res = UnityEngine.Random.Range(10, 500);
                break;
            case MaterialType.Orihalcon:
                res = UnityEngine.Random.Range(10, 600);
                break;
            case MaterialType.Adamantium:
                res = UnityEngine.Random.Range(10, 700);
                break;
        }

        switch (this.Rarity)
        {
            case RarityType.Broken:
                res += 0;
                break;
            case RarityType.Common:
                res += UnityEngine.Random.Range(0, 50);
                break;
            case RarityType.Uncommon:
                res += UnityEngine.Random.Range(25, 100);
                break;
            case RarityType.Rare:
                res += UnityEngine.Random.Range(50, 200);
                break;
            case RarityType.Epic:
                res += UnityEngine.Random.Range(100, 300);
                break;
            case RarityType.Legendary:
                res += UnityEngine.Random.Range(200, 399);
                break;
        }
        return res;
    }

    private float InitAtkPerSec()
    {
        switch (WeaponType)
        {
            case WeaponType.Axe: return UnityEngine.Random.Range(1.0f, 2.5f);
            case WeaponType.Bow: return UnityEngine.Random.Range(1.0f, 2.0f);
            case WeaponType.Daggers: return UnityEngine.Random.Range(0.5f, 1.8f);
            case WeaponType.Hammer: return UnityEngine.Random.Range(1.5f, 2.5f);
            case WeaponType.Mace: return UnityEngine.Random.Range(1.8f, 3.0f);
            case WeaponType.Scepter: return UnityEngine.Random.Range(1.8f, 3.0f);
            case WeaponType.Spear: return UnityEngine.Random.Range(1.0f, 2.5f);
            case WeaponType.Staff: return UnityEngine.Random.Range(1.0f, 2.5f);
            case WeaponType.Sword: return UnityEngine.Random.Range(1.0f, 2.5f);
            case WeaponType.Tome: return UnityEngine.Random.Range(1.8f, 3.0f);
        }
        return 0.0f;
    }
    #region Overriding
    public override string NameGenerator()
    {
        string nameGenerate = Rarity.ToString() + " " + MaterialName.ToString() + " " + WeaponType.ToString();
        return nameGenerate;
    }

    public override Sprite GetSprite()
    {
        switch (WeaponType)
        {
            case WeaponType.Axe:        return ItemAssets.Instance.axeList[UnityEngine.Random.Range(0, ItemAssets.Instance.axeList.Count)];
            case WeaponType.Bow:        return ItemAssets.Instance.bowList[UnityEngine.Random.Range(0, ItemAssets.Instance.bowList.Count)];
            case WeaponType.Daggers:    return ItemAssets.Instance.daggersList[UnityEngine.Random.Range(0, ItemAssets.Instance.daggersList.Count)];
            case WeaponType.Hammer:     return ItemAssets.Instance.hammerList[UnityEngine.Random.Range(0, ItemAssets.Instance.hammerList.Count)];
            case WeaponType.Mace:       return ItemAssets.Instance.maceList[UnityEngine.Random.Range(0, ItemAssets.Instance.maceList.Count)];
            case WeaponType.Scepter:    return ItemAssets.Instance.scepterList[UnityEngine.Random.Range(0, ItemAssets.Instance.scepterList.Count)];
            case WeaponType.Spear:      return ItemAssets.Instance.spearList[UnityEngine.Random.Range(0, ItemAssets.Instance.spearList.Count)];
            case WeaponType.Staff:      return ItemAssets.Instance.staffList[UnityEngine.Random.Range(0, ItemAssets.Instance.staffList.Count)];
            case WeaponType.Sword:      return ItemAssets.Instance.swordList[UnityEngine.Random.Range(0, ItemAssets.Instance.swordList.Count)];
            case WeaponType.Tome:       return ItemAssets.Instance.tomeList[UnityEngine.Random.Range(0, ItemAssets.Instance.tomeList.Count)];
        }
        return ItemAssets.Instance.defaultSprite;
    }

    public override string DisplayStats()
    {
        string description = this.Name + "\n";
        if (this.IsTwoHanded)
        {
            description += "Two Handed\n";
        }
        description += "Attack : " + this.MinDamage + "-" + this.MaxDamage + "\n";
        description += "Attack Speed : " + Math.Round(this.AtkPerSec, 2) + "\n";
        description += base.DisplayStats();
        if (this.CriticalChance != 0)
        {
            description += "Critical Rate : " + Math.Round(this.CriticalChance, 2) + "\n";
            description += "Critical Damage : " + Math.Round(this.CriticalDamage, 2) + "\n";
        }
        if(this.attributeList.Count != 0)
        {
            foreach(Attribute elem in attributeList)
            {
                description += elem.attributeType.ToString() + " Damage : " + elem.value + "\n";
            }
        }
        if(this.subDamageList.Count != 0)
        {
            foreach (SubDamage elem in subDamageList)
            {
                description += elem.subDamageType.ToString() + " Damage : " + elem.value + " Rate : " + Math.Round(elem.pct, 2) + " pct.\n";
            }
        }
        if(this.ailmentList.Count != 0)
        {
            foreach (Ailment elem in ailmentList)
            {
                description += elem.ailmentType.ToString() + " Damage : " + elem.value + " Rate : " + Math.Round(elem.pct, 2) + " pct." + "\nDuration : " + Math.Round(elem.duration, 1) + "\n";
            }
        }
        return description;
    }
    #endregion
    #endregion
}