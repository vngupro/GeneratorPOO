using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_GO : MonoBehaviour
{
    public Weapon weapon;
    [SerializeField] private List<Sprite> sprites = new List<Sprite>();

    Sprite sprite;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
    }
}
