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
                    RessourceList[RessourceList.Count - 1].DisplayStats();
                    break;

                case 1:
                    RessourceList.Add(new Bonus("Bonus"));
                    RessourceList[RessourceList.Count - 1].DisplayStats();
                    break;
            }
            Debug.Log(RessourceList[RessourceList.Count - 1].GetType());
            GameEvents.RessourceGenerated.Invoke(RessourceList[RessourceList.Count - 1]);
        }
        
    }
}
