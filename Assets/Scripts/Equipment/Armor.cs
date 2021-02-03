using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Equipment
{
    //Variable
    int value = 0;
    ArmorType armorType = ArmorType.HELMET;
    List<Resistance> resistanceList = new List<Resistance>();

    //Constructor
    public Armor()
    {
        value = Random.Range(1, 999);
        ArmorType armorType = (ArmorType)Random.Range(0, 8);
    }

    //Method
    public override string EquipementNameGenerator()
    {
        string nameGenerate = "Armor";
        return nameGenerate;
    }
}
