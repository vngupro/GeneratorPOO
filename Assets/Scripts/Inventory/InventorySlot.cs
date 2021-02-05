using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    private bool mouse_over = false;
    private Player player;
    private Text texte;
    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        texte = player.GetComponent<Text>();
    }
    void Update()
    {
        if (mouse_over)
        {
            player.texte.text = item.DisplayStats();
            if(player.mousePos.x > 0.8f)
            {
                player.StatsFrame.transform.position = (player.mousePos * new Vector2(Screen.width, Screen.height)) - new Vector2(Screen.width/12, Screen.height/5);
            }
            else if(player.mousePos.x > 0.2f)
            {
                player.StatsFrame.transform.position = (player.mousePos * new Vector2(Screen.width, Screen.height)) - new Vector2(0, Screen.height / 5);
            }
            else
            {
                player.StatsFrame.transform.position = (player.mousePos * new Vector2(Screen.width, Screen.height)) - new Vector2(-Screen.width / 12, Screen.height / 5);
            }

            if(player.mousePos.y < 0.5f)
            {
                player.StatsFrame.transform.position = new Vector2(player.StatsFrame.transform.position.x, player.mousePos.y * Screen.height + Screen.height / 5);
            }
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        player.StatsFrame.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        player.StatsFrame.SetActive(false);
    }
}
