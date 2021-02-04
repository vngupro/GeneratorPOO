using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Bonus : Ressource
{
    public BonusEffect BEffect { get; set; }
    public string Attribut = "Bonus";
    public override void DisplayStats()
    {
       
        Stats = "class : " + this.GetType().ToString() + " | name : " + Name + " Type : " + itemType.ToString() + " | Effect : " + BEffect.ToString();
        base.DisplayStats();
        
    }
    public Bonus(string _name) : base(_name)
    {
        name = _name;
        BEffect = (BonusEffect)(Random.Range(0, 4));
    }
    public override Sprite GetSprite()
    {
        return ItemAssets.Instance.axeSprite;
    }
}

class Malus : Ressource
{
    public MalusEffect MEffect { get; set; }
    public string Attribut = "Malus";
    public override void DisplayStats()
    {
        
        Stats = "class : " + this.GetType().ToString() + " | name : " + Name + " Type : " + itemType.ToString() + " | Effect : " + MEffect.ToString();
        base.DisplayStats();
    }
    public Malus(string _name) : base(_name)
    {
        name = _name;
        MEffect = (MalusEffect)(Random.Range(0,4));
    }
    public override Sprite GetSprite()
    {
        return ItemAssets.Instance.daggersSprite;
    }
}
