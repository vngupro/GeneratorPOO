using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{                                                   
    private List<Item> itemList = new List<Item>();
    [SerializeField] private InventorySlot slotPrefab;
    [SerializeField] GameObject inventory_ui;
    private void Awake()
    {
        //Invoke | Equipment Generator
        GameEvents.EquipmentGenerated.AddListener(AddItem);
    }
    public void AddItem(Item newItem)
    {
        InventorySlot newSlot = Instantiate(slotPrefab, inventory_ui.transform);
        newSlot.transform.SetParent(inventory_ui.transform);
        newSlot.item = newItem;
        itemList.Add(newItem);
        Debug.Log("add item");

        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {

        //int x = 0;
        //int y = 0;
        //float itemSlotCellSize = 26.0f;

        //foreach (InventorySlot slot in slots)
        //{
        //    RectTransform slotRectTransform = Instantiate(slotTemplate, slotContainer).GetComponent<RectTransform>();
        //    slotRectTransform.gameObject.SetActive(true);
        //    slotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
        //    Image image = slotRectTransform.Find("image").GetComponent<Image>();
        //    image.sprite = slot.item.GetSprite();
        //    x++;
        //    if (x > 20)
        //    {
        //        x = 0;
        //        y++;
        //    }
        //}
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
