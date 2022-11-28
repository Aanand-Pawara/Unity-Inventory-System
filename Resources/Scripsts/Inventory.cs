using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int invetorySize; 
    public InventoryType inventoryType;

    public List<Holder> Holders = new List<Holder>();
    private void Start()
    {
        GameUI.SetRefrences();
        IntializeInventory(inventoryType);
    }
    public void IntializeInventory(InventoryType _inventoryType) 
    {
        invetorySize = _inventoryType.Size;
        for(int i = 1; i < invetorySize; i++)
        {
            GameObject tempholder = GameObject.Instantiate(GameUI.InventoryHolder);
            tempholder.transform.SetParent(GameUI.InventoryUI.Content.transform);
            Holders.Add(tempholder.GetComponent<Holder>());
        }
    }
}
