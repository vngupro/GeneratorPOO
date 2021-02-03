using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ailment
{
    //Variable
    public AilmentType ailmentType = AilmentType.NONE;
    public float pct = .0f;
    public int value = 0;
    public float duration = .0f;

    //Constructor
    public Ailment()
    {
        ailmentType = (AilmentType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(AilmentType)).Length);
        pct = UnityEngine.Random.Range(0.5f, 100.0f);
        value = UnityEngine.Random.Range(1, 500);
        duration = UnityEngine.Random.Range(0.5f, 8.0f);
    }
}