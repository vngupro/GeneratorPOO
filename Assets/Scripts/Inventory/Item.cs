using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string Name { get; protected set; } = "";
    public ItemTypes itemType = ItemTypes.NONE;
    public virtual string EquipementNameGenerator()
    {
        string nameGenerate = "Random Equipment";
        return nameGenerate;
    }
    public virtual string DisplayStats()
    {
        return "Item";
    }

    public virtual Sprite GetSprite()
    {
        return ItemAssets.Instance.defaultSprite;
    }

    public virtual Color GetColor()
    {
        Color color = Color.white;

        return color;
    }
}

