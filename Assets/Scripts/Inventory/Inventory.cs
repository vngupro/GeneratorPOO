using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{                                                   
    private List<InventorySlot> slots = new List<InventorySlot>();
    [SerializeField] private InventorySlot slotPrefab;
    [SerializeField] GameObject inventory_ui;
    private void Awake()
    {
        //Invoke | Equipment Generator
        GameEvents.EquipmentGenerated.AddListener(AddItem);
    }
    public void AddItem(Item newItem)
    {
        InventorySlot slot = new InventorySlot();
        slot.item = newItem;
        slots.Add(slot);
        Debug.Log("add item");
        slot = Instantiate(slotPrefab, inventory_ui.transform);
        slot.transform.parent = inventory_ui.transform;
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
