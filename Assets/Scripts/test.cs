
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    //CLASS
    class Ressource
    {
        public string name;
        public virtual void AfficherInfos()
        {
            Debug.Log("Ressource " + name);
        }
    }
    class Bonus : Ressource
    {
        public string Attribut = "Bonus";

        public override void AfficherInfos()
        {
            Debug.Log("Ressource " + name);
            base.AfficherInfos();
        }
    }
    class Malus : Ressource
    {
        public string Attribut = "Malus";
        public override void AfficherInfos()
        {
            Debug.Log("Ressource " + name);
            base.AfficherInfos();
        }
    }
    static List<Ressource>RessouceList = new List<Ressource>();
    public int random;

    public void GenerateRessource()
    {
        for(int i = 0; i< 3; i++)
        {
            random = Random.Range(0, 1);
            switch(random){
                case 0:
                    RessouceList.Add(new Malus());     
                    break;

                case 1:
                    RessouceList.Add(new Bonus());
                    break;
            }
            Debug.Log(RessouceList[i].name);

        }
        Debug.Log(RessouceList.Count);
    }
}
