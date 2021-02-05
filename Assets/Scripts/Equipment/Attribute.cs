using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attribute
{
    //Variable
    public AttributeType attributeType = AttributeType.ACID;
    public int value = 0;

    //Constructor
    public Attribute()
    {
        this.attributeType = (AttributeType)(UnityEngine.Random.Range(0, Enum.GetValues(typeof(AttributeType)).Length));
        this.value = UnityEngine.Random.Range(50, 999);
    }
    
    public Attribute(AttributeType type)
    {
        this.attributeType = type;
        this.value = UnityEngine.Random.Range(50, 999);
    }
}
