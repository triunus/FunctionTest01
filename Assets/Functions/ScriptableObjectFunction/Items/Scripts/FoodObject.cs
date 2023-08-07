using UnityEngine;

[CreateAssetMenu(fileName = "New Food Object", menuName = "Inventory System/Items/Food")]
public class FoodObject : ItemObject
{
    [SerializeField]
    private int restoreHealthValue;

    private void Awake()
    {
        this.itemType = ItemType.Food;
    }
}
