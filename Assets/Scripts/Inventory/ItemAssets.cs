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
    public List<Sprite> swordList = new List<Sprite>();
    public List<Sprite> axeList = new List<Sprite>();
    public List<Sprite> spearList = new List<Sprite>();
    public List<Sprite> maceList = new List<Sprite>();
    public List<Sprite> hammerList = new List<Sprite>();
    public List<Sprite> daggersList = new List<Sprite>();
    public List<Sprite> bowList = new List<Sprite>();
    public List<Sprite> scepterList = new List<Sprite>();
    public List<Sprite> staffList = new List<Sprite>();
    public List<Sprite> tomeList = new List<Sprite>();

    //Armor
    public List<Sprite> helmetList = new List<Sprite>();
    public List<Sprite> shoulderList = new List<Sprite>();
    public List<Sprite> plastronList = new List<Sprite>();
    public List<Sprite> beltList = new List<Sprite>();
    public List<Sprite> glovesList = new List<Sprite>();
    public List<Sprite> pantsList = new List<Sprite>();
    public List<Sprite> bootsList = new List<Sprite>();
    public List<Sprite> shieldList = new List<Sprite>();
    public List<Sprite> capeList = new List<Sprite>();

    public Sprite Good;
    public Sprite Bad;
}
