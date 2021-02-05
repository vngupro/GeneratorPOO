using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Singleton_Event : MonoBehaviour
{
    private static Singleton_Event _instance = null;

    public static Singleton_Event Instance
    {
        get => _instance;
    }

    private void Awake()
    {
        _instance = this;
    }

}
public static class GameEvents
{
    public static ActionEvent RessourceGenerated = new ActionEvent();
    public static ActionEvent EquipmentGenerated = new ActionEvent();
}
public class ActionEvent : UnityEvent<Item> { }
