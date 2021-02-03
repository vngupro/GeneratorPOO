using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment
{
    //Properties
    public string Name { get; protected set; } = "";
    public StatType StatRequire { get; protected set; } = StatType.NONE;

    public int MaxDurability { get; private set; } = 0;
    public int Level { get; private set; } = 0;
    public int PlayerLevelRequire { get; private set; } = 0;
    public int StatValueRequire { get; private set; } = 0;
    public MaterialType materialType { get; private set; } = MaterialType.Bronze;
    public RarityType rarity { get; private set; } = RarityType.Broken;

    //Variable
    public int durability = 0;

    //Constructor
    public Equipment()
    {
        MaxDurability = Random.Range(100, 999);
        Level = Random.Range(1, 99);
        PlayerLevelRequire = Random.Range(1, 99);
        StatRequire = GetStatRequire();
        if(StatRequire != StatType.NONE)
        {
            StatValueRequire = Random.Range(1, 99);
        }
        durability = MaxDurability;
        materialType = (MaterialType)(Random.Range(0, 6));
        rarity = (RarityType)(Random.Range(0, 5));   
    }

    //Method
    public virtual string EquipementNameGenerator()
    {
        string nameGenerate = "Random Equipment";
        return nameGenerate;
    }

    public static StatType GetStatRequire()
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