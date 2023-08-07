using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    [SerializeField]
    private List<InventorySlot> container;

    private void Awake()
    {
        this.container = new List<InventorySlot>();
    }

    public void AddItem(ItemObject itemObject_, int _amount)
    {
        bool hasItem = false;

        for(int i =0; i < this.container.Count; ++i)
        {
            if(this.container[i].ItemObject == itemObject_)
            {
                this.container[i].AddAmount(_amount);
                hasItem = true;
                break;
            }
        }
        if (!hasItem)
        {
            this.container.Add(new InventorySlot(itemObject_, _amount));
        }
    }
}

[System.Serializable]
public class InventorySlot
{
    [SerializeField]
    private ItemObject itemObject_;
    [SerializeField]
    private int amount;

    public InventorySlot(ItemObject itemObject_, int amount)
    {
        this.itemObject_ = itemObject_;
        this.amount = amount;
    }

    public ItemObject ItemObject
    {
        get { return this.itemObject_; }
        set { this.itemObject_ = value; }
    }
    public int Amount
    {
        get { return this.amount; }
        set { this.amount = value; }
    }
    public void AddAmount(int value)
    {
        this.amount += value;
    }
}
