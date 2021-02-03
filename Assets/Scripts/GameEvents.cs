using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class GameEvents
{
    public static ActionEvent RessourceGenerated = new ActionEvent();
    public static ActionEvent EquipmentGenerated = new ActionEvent();
    public static ActionEvent PickedUpItem = new ActionEvent();
    public static ActionEvent PutDownItem = new ActionEvent();
    public static ActionEvent HoverOnItem = new ActionEvent();
}
public class ActionEvent : UnityEvent<Item> { }
