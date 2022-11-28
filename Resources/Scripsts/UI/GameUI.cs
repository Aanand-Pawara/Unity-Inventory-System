using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameUI
{
    public static GameObject InventoryHolder;
    public static InventoryUI InventoryUI;

    public static void SetRefrences()
    {
        if (!InventoryHolder)
        {
            InventoryHolder = Resources.Load<GameObject>("Prefabs/Holder");
        }
        if(!InventoryUI)
        {
            InventoryUI = GameObject.FindGameObjectWithTag("InventoryUI").GetComponent<InventoryUI>();
        }
    }
}
