using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Equipment
{
    int value = 0;
    ArmorType armorType = ArmorType.HELMET;
    List<Resistance> resistanceList = new List<Resistance>();
}
