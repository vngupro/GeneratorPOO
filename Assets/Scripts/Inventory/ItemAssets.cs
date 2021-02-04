using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite defaultSprite;

    //Weapons
    public Sprite swordSprite;
    public Sprite axeSprite;
    public Sprite spearSprite;
    public Sprite maceSprite;
    public Sprite hammerSprite;
    public Sprite daggersSprite;
    public Sprite bowSprite;
    public Sprite scepterSprite;
    public Sprite staffSprite;
    public Sprite tomeSprite;

    //Armor
    public Sprite helmetSprite;
    public Sprite shoulderSprite;
    public Sprite plastronSprite;
    public Sprite beltSprite;
    public Sprite glovesSprite;
    public Sprite pantsSprite;
    public Sprite bootsSprite;
    public Sprite shieldSprite;
    public Sprite capeSprite;
}
