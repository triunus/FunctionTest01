using UnityEngine;

[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Default")]
public class DefaultObject : ItemObject
{
    private void Awake()
    {
        this.itemType = ItemType.Default;
    }
}
