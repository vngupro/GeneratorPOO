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
    private int yIndex = -1;

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
            AddItemUI(newItem);
        }
    }

    public void AddItemUI(Item newItem)
    {
        //show item in inventory ui
        InventorySlot newSlot = Instantiate(slotPrefab, inventory_ui.transform);
        newSlot.item = newItem;
        newSlot.transform.GetChild(newSlot.transform.childCount - 1).GetComponent<Image>().sprite = newItem.GetSprite();
        newSlot.transform.SetParent(inventory_ui.transform);

        //change row
        if ((itemList.Count - 1) % 15 == 0)
        {
            yIndex++;
        }

        //set position
        newSlot.transform.position = new Vector2(startPos.transform.position.x + ((itemList.Count - 1) % 15) * xDistance, startPos.transform.position.y - yIndex * yDistance);
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
