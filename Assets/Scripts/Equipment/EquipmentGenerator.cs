using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentGenerator : MonoBehaviour
{
    [SerializeField] private List<Armor> armorList = new List<Armor>();
    [SerializeField] private List<Weapon> weaponList = new List<Weapon>();
    private int rng = 0;
    private int previousRng = 0;

    [SerializeField] Weapon_GO weaponRef;
    [SerializeField] Armor_GO armorRef;
    public void GenerateEquipment()
    {
        for(int i = 0; i < 3; i++)
        {
            rng = Random.Range(0, 99);
            NotTwiceTheSame(i, rng, previousRng);

            if (rng < 50)
            {
                weaponList.Add(new Weapon());
                weaponRef.weapon = weaponList[weaponList.Count - 1];
                Instantiate(weaponRef);
                Debug.Log("Weapon Generate");
            }
            else
            {
                armorList.Add(new Armor());
                armorRef.armor = armorList[armorList.Count - 1];
                Instantiate(armorRef);
                Debug.Log("Armor Generate");
            }

            previousRng = rng;
        }
    }

    public void NotTwiceTheSame(int i, int rng, int previousRng)
    {
        if (i == 1)
        {
            if (previousRng < 50)
            {
                rng = 50;
            }
            else
            {
                rng = 0;
            }
        }
    }
}
