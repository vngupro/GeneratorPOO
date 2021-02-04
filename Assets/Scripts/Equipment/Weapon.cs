using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Equipment
{
    #region Variable
    public int MinDamage { get; private set; }  = 0;
    public int MaxDamage { get; private set; } = 0;                                                 
    public float AtkPerSec { get; private set; } = .0f;
    public bool IsTwoHanded { get; private set; } = false;
    public float CriticalChance { get; private set; } = .0f;
    public float CriticalDamage { get; private set; } = .0f;
    public WeaponType WeaponType { get; private set; } = WeaponType.Sword;
    #endregion
    #region Lists
    public List<Ailment> ailmentList = new List<Ailment>();
    public List<Attribute> attributeList = new List<Attribute>();
    public List<SubDamage> subDamageList = new List<SubDamage>();
    #endregion
    #region Construtor
    public Weapon()
    {
        this.itemType = ItemTypes.WEAPON;

        this.MinDamage = Random.Range(1, 998);
        do
        {
            this.MaxDamage = Random.Range(2, 999);
        } while (this.MaxDamage < this.MinDamage);

        this.AtkPerSec = Random.Range(0.5f, 2.5f);
        int rngTwoHanded = Random.Range(0, 99);
        this.IsTwoHanded = (rngTwoHanded < 50) ? true : false;
        this.CriticalChance = Random.Range(0.0f, 100.0f);
        this.CriticalDamage = Random.Range(10.0f, 200.0f);
        int rngDamageType = Random.Range(0, 99);
        this.WeaponType = (WeaponType)(Random.Range(0, 9));

        do
        {
            ailmentList.Add(CreateAilment());
        } while (ailmentList[ailmentList.Count - 1].ailmentType != AilmentType.NONE);

        do
        {
            attributeList.Add(CreateAttribute());
        } while (attributeList[attributeList.Count - 1].attributeType != AttributeType.NONE);

        do
        {
            subDamageList.Add(CreateSubDamage());
        } while (subDamageList[subDamageList.Count - 1].subDamageType != SubDamageType.NONE);

        this.Name = EquipementNameGenerator();
    }
    #endregion
    #region Method
    public Ailment CreateAilment()
    {
        Ailment ailment = new Ailment();
        bool alreadyHave;
        do
        {
            alreadyHave = false;
            foreach (Ailment element in ailmentList)
            {
                if (ailment.ailmentType == element.ailmentType)
                {
                    alreadyHave = true;
                    ailment = new Ailment();
                }
            }
        } while (alreadyHave);

        return ailment;
    }
    public Attribute CreateAttribute()
    {
        Attribute attribute = new Attribute();
        bool alreadyHave;
        do
        {
            alreadyHave = false;
            foreach (Attribute element in attributeList)
            {
                if (attribute.attributeType == element.attributeType)
                {
                    alreadyHave = true;
                    attribute = new Attribute();
                }
            }
        } while (alreadyHave);

        return attribute;
    }
    public SubDamage CreateSubDamage()
    {
        SubDamage subDamage = new SubDamage();
        bool alreadyHave;
        do
        {
            alreadyHave = false;
            foreach (SubDamage element in subDamageList)
            {
                if (subDamage.subDamageType == element.subDamageType)
                {
                    alreadyHave = true;
                    subDamage = new SubDamage();
                }
            }
        } while (alreadyHave);

        return subDamage;
    }
    #region Overriding
    public override string EquipementNameGenerator()
    {
        string nameGenerate = Rarity.ToString() + " " + MaterialName.ToString() + " " + WeaponType.ToString();
        return nameGenerate;
    }

    public override Sprite GetSprite()
    {
        switch (WeaponType)
        {
            case WeaponType.Axe:        return ItemAssets.Instance.axeSprite;
            case WeaponType.Bow:        return ItemAssets.Instance.bowSprite;
            case WeaponType.Daggers:    return ItemAssets.Instance.daggersSprite;
            case WeaponType.Hammer:     return ItemAssets.Instance.hammerSprite;
            case WeaponType.Mace:       return ItemAssets.Instance.maceSprite;
            case WeaponType.Scepter:    return ItemAssets.Instance.scepterSprite;
            case WeaponType.Spear:      return ItemAssets.Instance.spearSprite;
            case WeaponType.Staff:      return ItemAssets.Instance.staffSprite;
            case WeaponType.Sword:      return ItemAssets.Instance.swordSprite;
            case WeaponType.Tome:       return ItemAssets.Instance.tomeSprite;
        }
        return ItemAssets.Instance.defaultSprite;
    }
    #endregion
    #endregion
}