using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public Text texte;
    private GameObject itemInHand = null;                       //GameObject inside player hand
    public Vector2 mousePos = new Vector2(0, 0);               //Mouse Position in World Space
    private bool hasItemInHand = false;
    public GameObject StatsFrame;
    private void Awake()
    {

        //Initialize
        itemInHand = null; 
        mousePos = new Vector2(0, 0);
        hasItemInHand = false;
        //inventory = GetComponentInChildren<Inventory>();
        //Invoke in 
        GameEvents.PutDownItem.AddListener(RemoveItemInHand);
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //ActionOnClick();
        MoveItemInHand();
        PutDownItem();
        HoverItem();
    }

    /*private void ActionOnClick()
    {
        if (Input.GetMouseButtonDown(0) && !hasItemInHand)
        {
            //Check hit
            RaycastHit2D hasClickOnItem = Physics2D.Raycast(mousePos, Vector2.zero, Mathf.Infinity, LayerMask.GetMask("Item"));

            //Pick Up
            if (hasClickOnItem)
            {
                //stock object in player hand
                itemInHand = hasClickOnItem.transform.gameObject;
                //UserEvent.pickUpItem.Invoke(mousePos);
                hasItemInHand = true;
            }
        }
    }*/

    private void HoverItem()
    {
        //RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
        //test = hit.transform.gameObject.GetComponent<Item>().GetType().ToString();
        //texte.text = hit.transform.gameObject.GetComponent<Item>().GetType().ToString();
    }
    

    //Move Item with Player
    private void MoveItemInHand()
    {
        if (hasItemInHand)
        {
            itemInHand.transform.position = mousePos;
        }
    }

    //Player put down item in InventoryGrid or in CraftGrid
    private void PutDownItem()
    {
        if (Input.GetMouseButtonUp(0) && hasItemInHand)
        {
            //in Inventory.cs
            //in CraftManager.cs
            //UserEvent.putDownItem.Invoke(new PutDownEventData(mousePos, itemInHand));

            //Player Release Item outside of Inventory Grid & Craft Grid
            //Put Item in Free Inventory Slot
            if (hasItemInHand)
            {
                //UserEvent.putInFreeSlot.Invoke(new PutDownEventData(mousePos, itemInHand));
            }
        }
    }
    //Player put down the Item
    private void RemoveItemInHand(Item item)
    {
        hasItemInHand = false;
    }
}
