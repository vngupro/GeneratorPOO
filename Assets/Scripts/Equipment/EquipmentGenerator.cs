using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentGenerator : MonoBehaviour
{
    public List<Equipment> equipmentList = new List<Equipment>();

    private int rng = 0;
    private int previousRng = 0;

    public void GenerateEquipment()
    {
        for(int i = 0; i < 3; i++)
        {
            rng = Random.Range(0, 99);
            NotTwiceTheSame(i, rng, previousRng);

            if (rng < 50)
            {
                equipmentList.Add(new Weapon());
                //Debug.Log(equipmentList[equipmentList.Count - 1].Name);
            }
            else
            {
                equipmentList.Add(new Armor());
                //Debug.Log(equipmentList[equipmentList.Count - 1].Name);
            }

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

    /*     
 *   * Equipement_UI -> recuperer List<Equipment>
     * Sprite pool 
     * private override -> recuperer les valeurs de variables
     * Unity Events -> automatic
*/

    /* Inventory Class Monobehavior
     * -> List<InventorySlot> slots;
     * 
     * InventorySlot -> Monobehavior
     * Item -> No monobehavior
     * 
     * Equipment 
     *              -> Inherit de Item
     * Ressource 
     * 
     * A chaque fois que tu generates E ou R
     *      -> Instancie 1 Inventory Slot -> et tu fais passer en pointeur E ou R en tant que Item 
                                             que tu stock dans InventorySlot.item;
     * 
     * ItemWorld -> Monobehavior pour apparaitre dans le game
     * 
     * Item -> Ressources
     *      -> Equipments
     * Ressouces ou Equipements pas hériter de Item
     * Tu peux pas les mettres dans InventorySlots 
     * 
     * InventorySlot = 1 slot 
     *  -> Equipemnt = nullptr;
     *  -> Ressouces = nullptr;
     *  selon les trucs generer -> Equipmenet = generate equipment
     *                          -> Ressource = genereate ressource
     *                          l'un ou l'autre mais jamais les 2 (XOR)
     *                           
     *  
     */
}
