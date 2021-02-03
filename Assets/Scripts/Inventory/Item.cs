using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string Name { get; protected set; } = "";
    public ItemTypes itemType { get; set; } = ItemTypes.NONE;
    
    public virtual string EquipementNameGenerator()
    {
        string nameGenerate = "Random Equipment";
        return nameGenerate;
    }
}

