using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [Header("DEBUG")]
    [SerializeField] private List<InventorySlot> slots = new List<InventorySlot>();
    private void Awake()
    {
        GameEvents.EquipmentGenerated.AddListener(AddItem);
        GameEvents.RessourceGenerated.AddListener(AddItem);
    }

    public void AddItem(Item newItem)
    {
        InventorySlot slot = new InventorySlot();
        slot.item = newItem;
        slots.Add(slot);
    }

    public void ShowInfo()
    {
        InventorySlot slot = slots[slots.Count - 1];
        switch (slot.item.itemType)
        {
            case ItemTypes.ARMOR:
                Armor armor = (Armor)slot.item;
                Debug.Log("Armor def value" + armor.Value);
                break;
            case ItemTypes.WEAPON:
                Weapon weapon = (Weapon)slot.item;
                Debug.Log("Weapon Max Value" + weapon.MaxDamage);
                break;
            case ItemTypes.BONUS:
                //Bonus bonus = (Bonus)slot.item;
                break;
            case ItemTypes.MALUS:
                //Malus malus = (Malus)slot.item;
                break;
            default:
                break;
        }
    }
}
