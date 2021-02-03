using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Equipment
{
    //Variable
    int _minDamage = 0;
    int _maxDamage = 0;
    float _atkPerSec = .0f;
    bool _isTwoHanded = false;
    float _criticalChance = .0f;
    float _criticalDamage = .0f;
    WeaponType _weaponType;
    List<Ailment> ailmentList = new List<Ailment>();
    List<Attribute> attributeList = new List<Attribute>();
    List<SubDamage> subDamageList = new List<SubDamage>();

    //Constructor
    public Weapon()
    {
        _minDamage = Random.Range(1, 998);
        do
        {
            _maxDamage = Random.Range(2, 999);
        } while (_maxDamage < _minDamage);

        _atkPerSec = Random.Range(0.5f, 2.5f);
        int rngTwoHanded = Random.Range(0, 99);
        _isTwoHanded = (rngTwoHanded < 50) ? true : false;
        _criticalChance = Random.Range(0.0f, 100.0f);
        _criticalDamage = Random.Range(10.0f, 200.0f);
        int rngDamageType = Random.Range(0, 99);
        _weaponType = (WeaponType)(Random.Range(0, 9));

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
        _name = EquipementNameGenerator();
    }

    //Method
    public override string EquipementNameGenerator()
    {
        string nameGenerate = rarity.ToString() + " " + materialType.ToString() + " " + _weaponType.ToString();
        return nameGenerate;
    }

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
}