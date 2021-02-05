using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ailment
{
    //Variable
    public AilmentType ailmentType = AilmentType.BLEED;
    public float pct = .0f;
    public int value = 0;
    public float duration = .0f;

    //Constructor
    public Ailment()
    {
        this.ailmentType = (AilmentType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(AilmentType)).Length);
        this.pct = UnityEngine.Random.Range(1.0f, 100.0f);
        this.value = UnityEngine.Random.Range(1, 999);
        this.duration = UnityEngine.Random.Range(1.0f, 10.0f);
    }

    public Ailment(AilmentType type)
    {
        this.ailmentType = type;
        this.pct = UnityEngine.Random.Range(1.0f, 100.0f);
        this.value = UnityEngine.Random.Range(1, 999);
        this.duration = UnityEngine.Random.Range(1.0f, 10.0f);
    }
}