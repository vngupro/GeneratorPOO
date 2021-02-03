using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item
{
    //Properties
   
    public StatType StatRequire { get; protected set; } = StatType.NONE;
    public int MaxDurability { get; private set; } = 0;
    public int Level { get; private set; } = 0;
    public int PlayerLevelRequire { get; private set; } = 0;
    public int StatValueRequire { get; private set; } = 0;
    public MaterialType materialType { get; private set; } = MaterialType.Bronze;
    public RarityType rarity { get; private set; } = RarityType.Broken;
    public int buyPrice { get; private set; } = 0;
    public int sellPrice { get; private set; } = 0;
    //Variable
    public int durability = 0;

    //Constructor
    public Equipment()
    {
        this.MaxDurability = Random.Range(100, 999);
        this.Level = Random.Range(1, 99);
        this.PlayerLevelRequire = Random.Range(1, 99);
        this.StatRequire = GetStatRequire();
        if(this.StatRequire != StatType.NONE)
        {
            this.StatValueRequire = Random.Range(1, 99);
        }
        this.durability = this.MaxDurability;
        this.materialType = (MaterialType)(Random.Range(0, 6));
        this.rarity = (RarityType)(Random.Range(0, 5));
        this.buyPrice = Random.Range(10, 9999);
        this.sellPrice = this.buyPrice / 2;
    }

    //Method
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