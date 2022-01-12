using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBaseHandler : MonoBehaviour
{
    public static DataBaseHandler handler;
    public int space;
    public List<Objects> Inventory;

    #region Singletion
    private void Awake()
    {
        if (handler = null)
        {
            handler = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);// can't be two handlers
        }

    }

    #endregion

    public void AddObjects(Objects objects)
    {
        if (Inventory.Count < space)
            Inventory.Add(objects);
        else
            Debug.Log("There is no more space");
    }
    public void DelateObjects(Objects objects)
    {
        Inventory.Remove(objects);
    }
}
