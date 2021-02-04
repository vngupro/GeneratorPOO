using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    private bool mouse_over = false;

    private void Awake()
    {
        item = GetComponentInParent<Inventory>().itemList[GetComponentInParent<Inventory>().itemList.Count - 1];
        transform.GetChild(transform.GetChildCount() - 1).GetComponent<Image>().sprite = item.GetSprite();
    }
    void Update()
    {
        if (mouse_over)
        {
            Debug.Log("Mouse Over");
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        Debug.Log("Mouse enter");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        Debug.Log("Mouse exit");
    }
}
