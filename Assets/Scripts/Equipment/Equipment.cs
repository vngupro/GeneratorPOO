using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item
{
    #region Variable | Properties
    public int Level { get; private set; } = 0;
    public int MaxDurability { get; private set; } = 0;
    public MaterialType MaterialName { get; private set; } = MaterialType.Bronze;
    public RarityType Rarity { get; private set; } = RarityType.Broken;
    public int PlayerLevelRequire { get; private set; } = 0;
    public StatType StatRequire { get; protected set; } = StatType.NONE;
    public int StatValueRequire { get; private set; } = 0;
    public int BuyPrice { get; private set; } = 0;
    public int SellPrice { get; private set; } = 0;
    public int durability = 0;
    #endregion
    #region Constructor
    public Equipment()
    {
        this.Level = Random.Range(1, 99);
        this.MaxDurability = Random.Range(100, 999);
        this.MaterialName = (MaterialType)(Random.Range(0, 6));
        this.Rarity = (RarityType)(Random.Range(0, 6));
        this.PlayerLevelRequire = InitPlayerLevelRequire();
        this.StatRequire = InitStatRequire();
        if (this.StatRequire != StatType.NONE)
        {
            this.StatValueRequire = InitStatValueRequire();
        }
        this.BuyPrice = InitBuyPrice();
        this.SellPrice = this.BuyPrice / 2;
        this.durability = this.MaxDurability;
    }
    #endregion
    #region Method
    private static StatType InitStatRequire()
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
    private int InitStatValueRequire()
    {
        int value = Random.Range(1, 20);
        switch (this.MaterialName)
        {
            case MaterialType.Bronze:
                value *= 1;
                break;
            case MaterialType.Silver:
                value *= 2;
                break;
            case MaterialType.Gold:
                value *= 3;
                break;
            case MaterialType.Platinum:
                value *= 4;
                break;
            case MaterialType.Mithril:
                value *= 5;
                break;
            case MaterialType.Orihalcon:
                value *= 6;
                break;
            case MaterialType.Adamantium:
                value *= 7;
                break;
            default:
                value *= 0;
                break;
        }
        int plusOrMinus = Random.Range(0, 99);
        if (plusOrMinus < 40)
        {
            value = AddPlusOrMinus(-value);
        }
        else if (plusOrMinus > 60)
        {
            value = AddPlusOrMinus(value);
        }
        return value;
    }
    private int InitPlayerLevelRequire()
    {
        switch (this.MaterialName)
        {
            case MaterialType.Bronze:       return Random.Range(1, 10);
            case MaterialType.Silver:       return Random.Range(10, 20);
            case MaterialType.Gold:         return Random.Range(20, 30);
            case MaterialType.Platinum:     return Random.Range(30, 40);
            case MaterialType.Mithril:      return Random.Range(40, 55);
            case MaterialType.Orihalcon:    return Random.Range(45, 65);
            case MaterialType.Adamantium:   return Random.Range(55, 70);
        }
        return 0;
    }
    private int InitBuyPrice()
    {
        int price = 0;
        price += AddRng(this.Level);
        price += AddRng(this.MaxDurability);
        price += AddRng(this.MaterialName);
        price += AddRng(this.Rarity);
        price += AddRng(this.PlayerLevelRequire);
        price += AddRng(this.StatValueRequire);
        return price;
    }
    private int AddPlusOrMinus(int value)
    {
        if (value > 100)
        {
            value += Random.Range(1, 50);
        }
        else if (value > 50)
        {
            value += Random.Range(1, 25);
        }
        else if (value > 25)
        {
            value += Random.Range(1, 10);
        }
        return Mathf.Abs(value);
    }
    private int AddRng(int value)
    {
        if (value > 100)
        {
            return Random.Range(300, 400);
        }
        else if (value > 50)
        {
            return Random.Range(200, 300);
        }
        else if (value > 25)
        {
            return Random.Range(100, 200);
        }
        else if (value > 10)
        {
            return Random.Range(1, 100);
        }
        return 0;
    }
    private int AddRng(MaterialType value)
    {
        switch (value)
        {
            case MaterialType.Bronze:       return Random.Range(1, 50);
            case MaterialType.Silver:       return Random.Range(50, 100);
            case MaterialType.Gold:         return Random.Range(100, 150);
            case MaterialType.Platinum:     return Random.Range(150, 200);
            case MaterialType.Mithril:      return Random.Range(200, 250);
            case MaterialType.Orihalcon:    return Random.Range(250, 300);
            case MaterialType.Adamantium:   return Random.Range(300, 350);
        }
        return 0;
    }
    private int AddRng(RarityType value)
    {
        switch (value)
        {
            case RarityType.Broken:         return Random.Range(1, 50);
            case RarityType.Common:         return Random.Range(50, 100);
            case RarityType.Uncommon:       return Random.Range(100, 150);
            case RarityType.Rare:           return Random.Range(150, 200);
            case RarityType.Epic:           return Random.Range(200, 250);
            case RarityType.Legendary:      return Random.Range(250, 300);
        }
        return 0;
    }
    public override Color GetColor()
    {
        switch (this.Rarity)
        {
            case RarityType.Broken:         return Color.grey;
            case RarityType.Common:         return Color.white;
            case RarityType.Uncommon:       return Color.green;
            case RarityType.Rare:           return Color.blue;
            case RarityType.Epic:           return Color.magenta;
            case RarityType.Legendary:      return Color.yellow;
        }
        return base.GetColor();
    }
    #endregion
}