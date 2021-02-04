using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    private bool mouse_over = false;

    
    void Update()
    {
        if (mouse_over)
        {
            item.DisplayStats();
            GameObject.Find("Player").GetComponent<Player>().texte.text = item.Stats;
            Debug.Log("Mouse Over");
           
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        Debug.Log("Mouse enter");
        GameObject.Find("Player").GetComponent<Player>().StatsFrame.SetActive(true);
        GameObject.Find("Player").GetComponent<Player>().StatsFrame.transform.position = (GameObject.Find("Player").GetComponent<Player>().mousePos * new Vector2(1920 , 1080))- new Vector2(100,100);

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        Debug.Log("Mouse exit");
        GameObject.Find("Player").GetComponent<Player>().StatsFrame.SetActive(false);
    }
}
