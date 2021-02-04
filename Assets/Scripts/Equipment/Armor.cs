using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Equipment
{
    //Properties
    public int Value { get; private set; } = 0;
    public ArmorType ArmorType { get; private set; } = ArmorType.Shield;
    
    //Lists
    public List<Resistance> resistanceList = new List<Resistance>();

    //Constructor
    public Armor()
    {
        this.itemType = ItemTypes.ARMOR;

        this.Value = Random.Range(1, 999);
        this.ArmorType = (ArmorType)(Random.Range(0, 8));
        this.Name = EquipementNameGenerator();
    }

    //Method
    public override string EquipementNameGenerator()
    {
        string nameGenerate = rarity.ToString() + " " + materialType.ToString() + " " + ArmorType.ToString();
        return nameGenerate;
    }

    public override Sprite GetSprite()
    {
        switch (ArmorType)
        {
            case ArmorType.Belt:        return ItemAssets.Instance.beltSprite;
            case ArmorType.Boots:       return ItemAssets.Instance.bootsSprite;
            case ArmorType.Gloves:      return ItemAssets.Instance.glovesSprite;
            case ArmorType.Helmet:      return ItemAssets.Instance.helmetSprite;
            case ArmorType.Plastron:    return ItemAssets.Instance.plastronSprite;
            case ArmorType.Shield:      return ItemAssets.Instance.shieldSprite;
            case ArmorType.Shoulder:    return ItemAssets.Instance.shoulderSprite;
            case ArmorType.Cape:        return ItemAssets.Instance.capeSprite;
        }
        return ItemAssets.Instance.defaultSprite;
    }
}
