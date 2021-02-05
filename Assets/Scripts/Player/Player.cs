using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public Text texte;
    public Vector2 mousePos = new Vector2(0, 0);               //Mouse Position in World Space
    public GameObject StatsFrame;

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }
}
