using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item item;

    private void Start()
    {
        item = GetComponentInParent<Inventory>().itemList[GetComponentInParent<Inventory>().itemList.Count - 1];
        transform.GetChild(transform.GetChildCount() - 1).GetComponent<Image>().sprite = item.GetSprite();
    }
}
