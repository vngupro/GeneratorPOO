using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceGenerator : MonoBehaviour
{

    private static Item item;
    public int random;
    [SerializeField] private AudioSource Potion;

    public void GenerateRessource()
    {
        Potion.Play();
        for (int i = 0; i < 3; i++)
        {
            random = Random.Range(0, 2);
            switch (random)
            {
                case 0:
                    item = new Malus("Malus");
                    break;

                case 1:
                    item = new Bonus("Bonus");
                    break;
            }

            //Listeer | Inventory.cs 
            GameEvents.RessourceGenerated.Invoke(item);
        }
        
    }
}
