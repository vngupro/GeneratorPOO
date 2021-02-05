using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceGenerator : MonoBehaviour
{

    static List<Ressource> RessourceList = new List<Ressource>();

    public int random;
    [SerializeField] AudioSource Potion;

    public void GenerateRessource()
    {
        Potion.Play();
        for (int i = 0; i < 3; i++)
        {
            random = Random.Range(0, 2);
            switch (random)
            {
                case 0:
                    RessourceList.Add(new Malus("Malus"));
                    RessourceList[RessourceList.Count - 1].DisplayStats();
                    break;

                case 1:
                    RessourceList.Add(new Bonus("Bonus"));
                    RessourceList[RessourceList.Count - 1].DisplayStats();
                    break;
            }

            //Listeer | Inventory.cs 
            GameEvents.RessourceGenerated.Invoke(RessourceList[RessourceList.Count - 1]);
        }
        
    }
}
