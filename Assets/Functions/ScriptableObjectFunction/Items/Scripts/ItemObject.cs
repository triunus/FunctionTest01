using System.Collections;
using UnityEngine;

public enum ItemType
{
    Default,
    Food,
    Equipment
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public ItemType itemType;
    [TextArea(15, 20)]
    public string description;
}
