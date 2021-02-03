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
        Value = Random.Range(1, 999);
        ArmorType armorType = (ArmorType)(Random.Range(0, 8));
        Name = EquipementNameGenerator();
    }

    //Method
    public override string EquipementNameGenerator()
    {
        string nameGenerate = rarity.ToString() + " " + materialType.ToString() + " " + ArmorType.ToString();
        return nameGenerate;
    }
}
