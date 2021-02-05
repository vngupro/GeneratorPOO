using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    private bool mouse_over = false;
    private Player player;
    private Text texte;
    private TMP_Text textBox;
    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        texte = player.GetComponent<Text>();
        textBox = player.GetComponent<TMP_Text>();
    }
    void Update()
    {
        if (mouse_over)
        {
            player.texte.text = item.DisplayStats();
            if(player.mousePos.x >= 0.5f)
            {
                player.StatsFrame.transform.position = (player.mousePos * new Vector2(1920, 1080)) - new Vector2(150, 50);
            }
            else if(player.mousePos.x >= 0.3f)
            {
                player.StatsFrame.transform.position = (player.mousePos * new Vector2(1920, 1080)) - new Vector2(0, 50);
            }
            else
            {
                player.StatsFrame.transform.position = (player.mousePos * new Vector2(1920, 1080)) - new Vector2(-150, 50);
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
