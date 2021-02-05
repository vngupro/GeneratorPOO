using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Bonus : Ressource
{
    public BonusEffect BEffect { get; set; }
    public string Attribut = "Bonus";
    public override string DisplayStats()
    {
        switch (this.BEffect)
        {
            case BonusEffect.STRENGTH_UP:
                return "Class : " + this.GetType().ToString() + "\nName : " + "Strength Potion" + "\nEffect : " + BEffect.ToString();
                break;

            case BonusEffect.VITALITY_UP :
                return "Class : " + this.GetType().ToString() + "\nName : " + "Vitality Potion" + "\nEffect : " + BEffect.ToString();
                break;

            case BonusEffect.DEXTERITY_UP:
                return "Class : " + this.GetType().ToString() + "\nName : " + "Dexterity Potion" + "\nEffect : " + BEffect.ToString();
                break;

            case BonusEffect.INTELLIGENCE_UP:
                return "Class : " + this.GetType().ToString() + "\nName : " + "Intelligence Potion" + "\nEffect : " + BEffect.ToString();
                break;

            case BonusEffect.LUCK_UP:
                return "Class : " + this.GetType().ToString() + "\nName : " + "Luck Potion" + "\nEffect : " + BEffect.ToString();
                break;
        }
        return "Class : " + this.GetType().ToString() + "\nName : " + Name + "\nEffect : " + BEffect.ToString();

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
        switch (this.MEffect)
        {
            case MalusEffect.STRENGTH_DOWN:
                return "Class : " + this.GetType().ToString() + "\nName : " + "Strength Debuff" + "\nEffect : " + MEffect.ToString();
                break;

            case MalusEffect.VITALITY_DOWN:
                return "Class : " + this.GetType().ToString() + "\nName : " + "Vitality Debuff" + "\nEffect : " + MEffect.ToString();
                break;

            case MalusEffect.DEXTERITY_DOWN:
                return "Class : " + this.GetType().ToString() + "\nName : " + "Dexterity Debuff" + "\nEffect : " + MEffect.ToString();
                break;

            case MalusEffect.INTELLIGENCE_DOWN:
                return "Class : " + this.GetType().ToString() + "\nName : " + "Intelligence Debuff" + "\nEffect : " + MEffect.ToString();
                break;

            case MalusEffect.LUCK_DOWN:
                return "Class : " + this.GetType().ToString() + "\nName : " + "Luck Debuff" + "\nEffect : " + MEffect.ToString();
                break;
        }
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
