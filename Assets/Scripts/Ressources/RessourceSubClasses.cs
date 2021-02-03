using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Bonus : Ressource
{
    public BonusEffect BEffect { get; set; }
    public string Attribut = "Bonus";
    public override void AfficherInfos()
    {
        Debug.Log("Ressource " + name);
        base.AfficherInfos();
    }
    public Bonus(string _name) : base(_name)
    {
        name = _name;
        BEffect = (BonusEffect)(Random.Range(0, 4));
    }
}

class Malus : Ressource
{
    public MalusEffect MEffect { get; set; }
    public string Attribut = "Malus";
    public override void AfficherInfos()
    {
        Debug.Log("Ressource " + name);
        base.AfficherInfos();
    }
    public Malus(string _name) : base(_name)
    {
        name = _name;
        MEffect = (MalusEffect)(Random.Range(0,4));
    }
}
