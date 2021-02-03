using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubDamage
{
    //Variable
    public SubDamageType subDamageType = SubDamageType.NONE;
    public float pct = .0f;
    
    //Constructor
    public SubDamage()
    {
        subDamageType = (SubDamageType)(UnityEngine.Random.Range(0, Enum.GetValues(typeof(SubDamageType)).Length));
        pct = UnityEngine.Random.Range(0.5f, 100.0f);
    }
    
}
