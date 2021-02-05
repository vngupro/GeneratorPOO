using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Equipment
{
    #region Variable
    public int Value { get; private set; } = 0;
    public ArmorType ArmorType { get; private set; } = ArmorType.Shield;
    #endregion
    #region Lists
    public List<Resistance> resistanceList = new List<Resistance>();
    #endregion
    #region Constructor
    public Armor()
    {
        this.itemType = ItemTypes.ARMOR;
        this.Value = InitValue();
        this.ArmorType = (ArmorType)(Random.Range(0, 8));
        CreateResistanceList();
        this.Name = EquipementNameGenerator();
    }
    #endregion
    #region Method
    private int InitValue()
    {
        switch (this.MaterialName)
        {
            case MaterialType.Bronze:       return Random.Range(1, 100);
            case MaterialType.Silver:       return Random.Range(75, 200);
            case MaterialType.Gold:         return Random.Range(150, 300);
            case MaterialType.Platinum:     return Random.Range(250, 400);
            case MaterialType.Mithril:      return Random.Range(300, 500);
            case MaterialType.Orihalcon:    return Random.Range(400, 600);
            case MaterialType.Adamantium:   return Random.Range(500, 999);
        }
        return 0;
    }
    private int NbrResistanceToCreate()
    {
        switch (this.Rarity)
        {
            case RarityType.Broken:         return 0;
            case RarityType.Common:         return Random.Range(0, 1);
            case RarityType.Uncommon:       return Random.Range(1, 3);
            case RarityType.Rare:           return Random.Range(3, 6);
            case RarityType.Epic:           return Random.Range(5, 9);
            case RarityType.Legendary:      return Random.Range(7, 11);
        }
        return 0;
    }
    public Resistance CreateResistance()
    {
        Resistance resistance = new Resistance();
        bool alreadyHave;
        do
        {
            alreadyHave = false;
            foreach (Resistance element in resistanceList)
            {
                if (resistance.resistanceType == element.resistanceType)
                {
                    alreadyHave = true;
                    resistance = new Resistance();
                }
            }
        } while (alreadyHave);

        return resistance;
    }

    private void CreateResistanceList()
    {
        int nbResistance = NbrResistanceToCreate();
        if (nbResistance == 0) return;
        for(int i = 0; i < nbResistance; i++)
        {
            resistanceList.Add(CreateResistance());
        }
    }
    public override string EquipementNameGenerator()
    {
        string nameGenerate = Rarity.ToString() + " " + MaterialName.ToString() + " " + ArmorType.ToString();
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
    #endregion
}
