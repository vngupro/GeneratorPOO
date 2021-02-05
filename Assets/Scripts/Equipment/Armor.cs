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
        this.ArmorType = (ArmorType)(Random.Range(0, 8));
        this.Value = InitValue();
        CreateResistanceList();
        this.Name = EquipementNameGenerator();
    }
    #endregion
    #region Method
    private int InitValue()
    {
        int res = 0;
        switch (this.MaterialName)
        {
            case MaterialType.Bronze:       res = Random.Range(1, 100); break;
            case MaterialType.Silver:       res = Random.Range(50, 200); break;
            case MaterialType.Gold:         res = Random.Range(150, 250); break;
            case MaterialType.Platinum:     res = Random.Range(200, 300); break; 
            case MaterialType.Mithril:      res = Random.Range(250, 350); break;
            case MaterialType.Orihalcon:    res = Random.Range(300, 400); break;
            case MaterialType.Adamantium:   res = Random.Range(350, 500); break;
        }

        switch (this.Rarity)
        {
            case RarityType.Broken:         res /= 2; break;
            case RarityType.Common:         res *= 1; break;
            case RarityType.Uncommon:       res *= 2; break;
            case RarityType.Rare:           res *= 3; break;
            case RarityType.Epic:           res *= 4; break;
            case RarityType.Legendary:      res *= 5; break;
        }
        return res;
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
            case ArmorType.Pants:       return ItemAssets.Instance.pantsSprite;
        }
        return ItemAssets.Instance.defaultSprite;
    }
    public override string DisplayStats()
    {
        string description = this.Name + "\n";
        description += "Defense : " + this.Value + "\n";
        if (this.resistanceList.Count != 0)
        {
            foreach (Resistance elem in resistanceList)
            {
                description += elem.resistanceType.ToString() + " Resistance : " + Mathf.Round(elem.pct) + "\n";
            }
        }
        return description;
    }
    #endregion
}
