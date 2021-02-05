using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentGenerator : MonoBehaviour
{
    private Item item;
    private int rng = 0;
    private int previousRng = 0;
    [SerializeField] AudioSource Anvil;

    public void GenerateEquipment()
    {
        Anvil.Play();
        for(int i = 0; i < 3; i++)
        {
            rng = Random.Range(0, 100);
            NotTwiceTheSame(i, rng, previousRng);

            if (rng < 50)
            {
                item = new Weapon();
            }
            else
            {
                item = new Armor();
            }

            //Listener | Inventory.cs
            GameEvents.EquipmentGenerated.Invoke(item);
            previousRng = rng;
        }
    }

    public static void NotTwiceTheSame(int i, int rng, int previousRng)
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
