using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private ItemObject itemObject_;

    public ItemObject ItemObject
    {
        get { return this.itemObject_; }
    }
}
