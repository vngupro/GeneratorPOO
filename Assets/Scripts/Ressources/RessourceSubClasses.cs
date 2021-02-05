using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Bonus : Ressource
{
    public BonusEffect BEffect { get; set; }
    public string Attribut = "Bonus";
    public override string DisplayStats()
    {
        return "Class : " + this.GetType().ToString() + "\nName : " + Name +  "\nEffect : " + BEffect.ToString();   
    }
    public Bonus(string _name) : base(_name)
    {
        name = _name;
        BEffect = (BonusEffect)(Random.Range(0, 4));
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
        return "Class : " + this.GetType().ToString() + "\nName : " + Name + "\nEffect : " + MEffect.ToString();
    }
    public Malus(string _name) : base(_name)
    {
        name = _name;
        MEffect = (MalusEffect)(Random.Range(0,4));
    }
    public override Sprite GetSprite()
    {
        return ItemAssets.Instance.Bad;
    }
}
