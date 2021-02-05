using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{                                                   
    public List<Item> itemList = new List<Item>();
    public GameObject inventory_ui;

    [SerializeField] private InventorySlot slotPrefab;
    [SerializeField] private GameObject startPos;
    [SerializeField] AudioSource ZaHando;

    [Header("DEBUG")]
    [SerializeField] private int xDistance = 180;                  //distance X between two slots
    [SerializeField] private int yDistance = 160;                  //distance Y between two slots
    private int yIndex = -1;                                       //row Count
    private static Inventory _instance;
    private void Awake() {

        if (_instance == null){

            _instance = this;
            DontDestroyOnLoad(this.gameObject);
    
            //Rest of your Awake code
    
        } else {
            Destroy(this);
        }

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
        if(yIndex != 6)
        {
            //show item in inventory ui
            InventorySlot newSlot = Instantiate(slotPrefab, inventory_ui.transform);
            newSlot.item = newItem;
            newSlot.transform.GetChild(newSlot.transform.childCount - 1).GetComponent<Image>().sprite = newItem.GetSprite();
            newSlot.transform.SetParent(inventory_ui.transform);
            newSlot.transform.GetChild(0).GetComponent<Image>().color = newItem.GetColor();
            //change row
            if ((itemList.Count - 1) % 15 == 0)
            {
                yIndex++;
            }

            //set position
            newSlot.transform.position = new Vector2(startPos.transform.position.x + ((itemList.Count - 1) % 15) * xDistance, startPos.transform.position.y - yIndex * yDistance);
        }
    }
    public void Reset()
    {
        ZaHando.Play();
        itemList.Clear();
        yIndex = -1;
        foreach (Transform child in inventory_ui.transform)
        {
            if (child.CompareTag("Slot"))
            {
                GameObject.Destroy(child.gameObject);
            }
        }
    }

}
