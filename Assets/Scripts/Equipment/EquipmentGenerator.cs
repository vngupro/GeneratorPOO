using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentGenerator : MonoBehaviour
{
    public List<Equipment> equipmentList = new List<Equipment>();

    public void GenerateEquipment()
    {
        int rng = 0;
        int previousRng = 0;

        for(int i = 0; i < 3; i++)
        {
            rng = Random.Range(0, 99);
            NotTwiceTheSame(i, rng, previousRng);

            if (rng < 50)
            {
                equipmentList.Add(new Weapon());
            }
            else
            {
                equipmentList.Add(new Armor());
            }

            //Listener | Inventory.cs
            GameEvents.EquipmentGenerated.Invoke(equipmentList[equipmentList.Count -1]);
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
