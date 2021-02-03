using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment
{
    //Variable 
    public string _name = "";
    int _maxDurability = 0;
    int _level = 0;
    int _playerLevelRequire = 0;
    StatType _statRequire = StatType.NONE;
    int _statValueRequire = 0;
    int durability = 0;
    public MaterialType materialType;
    public RarityType rarity;

    //Constructor
    public Equipment()
    {
        _maxDurability = Random.Range(100, 999);
        _level = Random.Range(1, 99);
        _playerLevelRequire = Random.Range(1, 99);
        _statRequire = StatRequire();
        if(_statRequire != StatType.NONE)
        {
            _statValueRequire = Random.Range(0, 99);
        }
        durability = _maxDurability;
        materialType = (MaterialType)(Random.Range(0, 6));
        rarity = (RarityType)(Random.Range(0, 5));   
    }

    //Method
    public virtual string EquipementNameGenerator()
    {
        string nameGenerate = "Random Equipment";
        return nameGenerate;
    }

    public StatType StatRequire()
    {
        StatType statType;
        int rngStatRequire = Random.Range(0, 5 * 3);
        switch (rngStatRequire)
        {
            case 0:
                statType = StatType.NONE;
                break;
            case 1:
                statType = StatType.DEXTERITY;
                break;
            case 2:
                statType = StatType.INTELLIGENCE;
                break;
            case 3:
                statType = StatType.VITALITY;
                break;
            case 4:
                statType = StatType.STRENGTH;
                break;
            case 5:
                statType = StatType.LUCK;
                break;
            default:
                statType = StatType.NONE;
                break;
        }
        return statType;
    }
}