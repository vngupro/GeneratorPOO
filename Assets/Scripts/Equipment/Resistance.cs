using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistance 
{
    //Variable 
    public ResistanceType resistanceType = ResistanceType.PHYSICAL;
    public float pct = .0f;
    
    //Constructor
    public Resistance()
    {
        this.resistanceType = (ResistanceType)(UnityEngine.Random.Range(0, Enum.GetValues(typeof(ResistanceType)).Length));
        this.pct = UnityEngine.Random.Range(10.0f, 100.0f);
    }

    public Resistance(ResistanceType type)
    {
        this.resistanceType = type;
        this.pct = UnityEngine.Random.Range(10.0f, 100.0f);
    }
}
