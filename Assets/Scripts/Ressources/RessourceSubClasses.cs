using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Bonus : Ressource
{
    public BonusEffect BEffect { get; set; }
    public string Attribut = "Bonus";
    public override string DisplayStats()
    {
        return "class : " + this.GetType().ToString() + " | name : " + Name +  " | Effect : " + BEffect.ToString();   
    }
    public Bonus(string _name) : base(_name)
    {
        name = _name;
        BEffect = (BonusEffect)(Random.Range(0, 4));
        this.itemType = ItemTypes.BONUS;
    }
    public override Sprite GetSprite()
    {
        return ItemAssets.Instance.Good;
    }
}

class Malus : Ressource
{
    public MalusEffect MEffect { get; set; }
    public string Attribut = "Malus";
    public override string DisplayStats()
    {     
        return "class : " + this.GetType().ToString() + " | name : " + Name + " | Effect : " + MEffect.ToString();
    }
    public Malus(string _name) : base(_name)
    {
        name = _name;
        MEffect = (MalusEffect)(Random.Range(0,4));
        this.itemType = ItemTypes.MALUS;
    }
    public override Sprite GetSprite()
    {
        return ItemAssets.Instance.Bad;
    }
}
