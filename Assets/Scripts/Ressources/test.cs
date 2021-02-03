using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
   
    static List<Malus>MalusList = new List<Malus>();
    static List<Bonus> BonusList = new List<Bonus>();
    public int random;

    public void GenerateRessource()
    {
        for(int i = 0; i< 3; i++)
        {
            random = Random.Range(0, 2);
            switch(random){
                case 0:
                    MalusList.Add(new Malus("Malus"));
                    Debug.Log(MalusList[MalusList.Count - 1].rarity.ToString() + " " + MalusList[MalusList.Count - 1].name + " generated !" + MalusList[MalusList.Count - 1].MEffect.ToString());
                    break;

                case 1:
                    BonusList.Add(new Bonus("Bonus"));
                    Debug.Log(BonusList[BonusList.Count-1].rarity.ToString() + " " + BonusList[BonusList.Count - 1].name + " generated !" + BonusList[BonusList.Count - 1].BEffect.ToString());
                    break;
            }

        }
    }
}
