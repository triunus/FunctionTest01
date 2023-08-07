using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")]
public class EquipmentObject : ItemObject
{
    [SerializeField]
    private float attackBonus;
    [SerializeField]
    private float defenceBonus;

    private void Awake()
    {
        this.itemType = ItemType.Equipment;
    }
}
