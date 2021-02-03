using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistance 
{
    //Variable 
    public ResistanceType resistanceType = ResistanceType.NONE;
    public float pct = .0f;
    
    //Constructor
    public Resistance()
    {
        resistanceType = (ResistanceType)(UnityEngine.Random.Range(0, Enum.GetValues(typeof(ResistanceType)).Length));
        pct = UnityEngine.Random.Range(0.5f, 100.0f);
    }
}
