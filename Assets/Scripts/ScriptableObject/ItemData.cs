using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{

    Equipable,
    Consumable,
    Resource
}

public enum ConsumableType
{
    
    Health,
    Hunger,
    SpeedBoost

}

[Serializable]
public class ItemDataConsumable
{
    public ConsumableType type;
    public float value;
    public float duration;
}

[CreateAssetMenu(fileName ="Item", menuName = "New Item")]

public class ItemData : ScriptableObject
{
    public float value;         
    public float duration;

    [Header("info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;

}
