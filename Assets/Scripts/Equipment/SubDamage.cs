using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubDamage
{
    //Variable
    public SubDamageType subDamageType = SubDamageType.BLUNT;       //Sub Damage Type
    public float pct = .0f;                                         //Chance to damage an enemy with this type
    public int value = 0;                                           //Value of the subDamage done (can influence ailment done)
    
    //Constructor
    public SubDamage()
    {
        subDamageType = (SubDamageType)(UnityEngine.Random.Range(0, Enum.GetValues(typeof(SubDamageType)).Length));
        pct = UnityEngine.Random.Range(0.5f, 100.0f);
        value = UnityEngine.Random.Range(10, 999);
    }

    public SubDamage(SubDamageType type, RarityType rarity, MaterialType material)
    {
        subDamageType = type;
        pct = InitPct(rarity);
        value = InitValue(rarity, material);
    }

    private int InitValue(RarityType rarity, MaterialType material)
    {
        int res = 0;
        switch (material)
        {
            case MaterialType.Bronze:       res = UnityEngine.Random.Range(1, 10);
                break;
            case MaterialType.Silver:       res = UnityEngine.Random.Range(1, 20);
                break;
            case MaterialType.Gold:         res = UnityEngine.Random.Range(5, 30);
                break;
            case MaterialType.Platinum:     res = UnityEngine.Random.Range(5, 40);
                break;
            case MaterialType.Mithril:      res = UnityEngine.Random.Range(10, 50);
                break;
            case MaterialType.Orihalcon:    res = UnityEngine.Random.Range(10, 60);
                break;
            case MaterialType.Adamantium:   res = UnityEngine.Random.Range(10, 70);
                break;
        }
        
        switch (rarity)
        {
            case RarityType.Broken:         res *= 0;
                break;
            case RarityType.Common:         res *= 1;
                break;
            case RarityType.Uncommon:       res *= 2;
                break;
            case RarityType.Rare:           res *= 3;
                break;
            case RarityType.Epic:           res *= 4;
                break;
            case RarityType.Legendary:      res *= 5;
                break;
        }
        return res;
    }

    private float InitPct(RarityType rarity)
    {
        switch (rarity)
        {
            case RarityType.Broken:         return UnityEngine.Random.Range(5.0f, 20.0f);
            case RarityType.Common:         return UnityEngine.Random.Range(5.0f, 30.0f);
            case RarityType.Uncommon:       return UnityEngine.Random.Range(5.0f, 40.0f);
            case RarityType.Rare:           return UnityEngine.Random.Range(10.0f, 50.0f);
            case RarityType.Epic:           return UnityEngine.Random.Range(10.0f, 70.0f);
            case RarityType.Legendary:      return UnityEngine.Random.Range(20.0f, 100.0f);
        }
        return 0.0f;
    }
    
}
