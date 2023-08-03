using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> container;

    private void Awake()
    {
        this.container = new List<InventorySlot>();
    }

    public void AddItem(ItemObject _item, int _amount)
    {
        bool hasItem = false;

        for(int i =0; i < this.container.Count; ++i)
        {
            if(this.container[i].item == _item)
            {
                this.container[i].AddAmount(_amount);
                hasItem = true;
                break;
            }
        }
        if (!hasItem)
        {
            this.container.Add(new InventorySlot(_item, _amount));
        }
    }
}

[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public int amount;

    public InventorySlot(ItemObject _item, int _amount)
    {
        this.item = _item;
        this.amount = _amount;
    }

    public void AddAmount(int value)
    {
        this.amount += value;
    }
}
