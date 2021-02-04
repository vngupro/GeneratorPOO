using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Ressource : Item
{
    public string name {get; set;}
    public RarityType rarity { get; set; }
    
    
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


