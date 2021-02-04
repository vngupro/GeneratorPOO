using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Ressource : Item
{
    public string name {get; set;}
    public RarityType rarity { get; set; }
    
    public virtual void AfficherInfos()
    {
        Debug.Log("Ressource " + name + "Rarity : " + rarity.ToString());
    }
    public Ressource(string _name)
    {
        name = _name;
        rarity = (RarityType)(Random.Range(0, 6));
    }
    public Ressource()
    {
        name = "Ressource";
    }
}


