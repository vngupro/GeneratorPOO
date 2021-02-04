using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{                                                   
    public List<Item> itemList = new List<Item>();
    [SerializeField] private InventorySlot slotPrefab;
    [SerializeField] GameObject inventory_ui;
    [SerializeField] GameObject startPos;
    [SerializeField] private int xDistance = 160;                  //distance between two slots
    [SerializeField] private int yDistance = 160;
    private int yIndex = 0;

    private void Awake() {
    
        //Invoke | EquipmentGenerator.cs
        GameEvents.EquipmentGenerated.AddListener(AddItem);
        GameEvents.RessourceGenerated.AddListener(AddItem);
    }
    public void AddItem(Item newItem)
    {
        if(itemList.Count != 15 * 6)
        {
            itemList.Add(newItem);
            InventorySlot newSlot = Instantiate(slotPrefab, inventory_ui.transform);
            newSlot.transform.SetParent(inventory_ui.transform);
            if (itemList.Count % 15 == 0)
            {
                yIndex++;
            }
            newSlot.transform.position = new Vector2(startPos.transform.position.x + ((itemList.Count-1) % 15) * xDistance, startPos.transform.position.y - yIndex * yDistance);
            newSlot.item = newItem;
            newSlot.transform.GetChild(newSlot.transform.childCount - 1).GetComponent<Image>().sprite = newItem.GetSprite();
            Debug.Log(newSlot.item.Name);
        }
    }

    public void ShowInfo()
    {
        Item item = itemList[itemList.Count - 1];
        switch (item.itemType)
        {
            case ItemTypes.ARMOR:
                Armor armor = (Armor)item;
                Debug.Log("Armor def value" + armor.Value);
                break;
            case ItemTypes.WEAPON:
                Weapon weapon = (Weapon)item;
                Debug.Log("Weapon Max Value" + weapon.MaxDamage);
                break;
            case ItemTypes.BONUS:
                //Bonus bonus = (Bonus)item;
                break;
            case ItemTypes.MALUS:
                //Malus malus = (Malus)item;
                break;
            default:
                break;
        }
    }

}
