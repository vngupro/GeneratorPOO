using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attribute
{
    //Variable
    public AttributeType attributeType = AttributeType.NONE;
    public int value = 0;

    //Constructor
    public Attribute()
    {
        attributeType = (AttributeType)(UnityEngine.Random.Range(0, Enum.GetValues(typeof(AttributeType)).Length));
        value = UnityEngine.Random.Range(50, 999);
    }
}
