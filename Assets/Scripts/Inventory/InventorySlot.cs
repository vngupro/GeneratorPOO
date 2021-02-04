using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public Item item = null;

    private void Start()
    {
        item = new Item();
    }
}
