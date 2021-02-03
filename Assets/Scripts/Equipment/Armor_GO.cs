using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor_GO : MonoBehaviour
{
    public Armor armor;
    [SerializeField] private List<Sprite> sprites = new List<Sprite>();

    Sprite sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;    
    }
}
