using Assets.Scripts.Interfaces;
using Assets.Scripts.Player;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInventoryUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject InventoryBG;
    
    void ClearInventory()
    {
        for(var i = 0; i < InventoryBG.transform.childCount; i++)
        {
            var _find = InventoryBG.transform.GetChild(i);
            Destroy(_find.gameObject);
        }
    }

    void UpdateInventory()
    {

        var obj = Resources.Load<GameObject>("ItemText");
        Debug.Log("Opened Inventory");
        var i = 0;
        foreach (IItem item in PlayerStats.Items)
        {
            i++;
            var inst = Instantiate(obj, InventoryBG.transform, false);
            var scr = inst.GetComponent<ItemText>();
            scr.Item = item;
        }
    }

    void OnEnable()
    {
        ClearInventory();
        UpdateInventory();
    }

    void OnDisable()
    {
        ClearInventory();
    }
}
