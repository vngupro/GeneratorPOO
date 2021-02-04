using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceGenerator : MonoBehaviour
{

    static List<Ressource> RessourceList = new List<Ressource>();

    public int random;

    public void GenerateRessource()
    {
        for (int i = 0; i < 3; i++)
        {
            random = Random.Range(0, 2);
            switch (random)
            {
                case 0:
                    RessourceList.Add(new Malus("Malus"));
                    break;

                case 1:
                    RessourceList.Add(new Bonus("Bonus"));
                    break;
            }
            GameEvents.RessourceGenerated.Invoke(RessourceList[RessourceList.Count - 1]);
        }
        
    }
}
