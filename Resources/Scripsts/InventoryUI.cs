using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public GameObject Content;
    public GameObject Panel;
    public GameObject object1;

    public InventoryUI GetUI()
    {
        return this;
    }
    public void EnableUI(bool tru)
    {
        Panel.SetActive(tru);
    }

    public bool IsActive()
    {
        if(Panel.activeInHierarchy)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
