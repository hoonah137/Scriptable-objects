using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public ScriptableItem[] weapons;
    public Text[] weaponsName;
    public Image[] weaponsSprite;

    public InventorySlots[] weaponSlots;
    
    void Awake()
    {
        instance = this;
    }
    
    public void AddItem(ScriptableItem item)
    {
        for (var i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsName[i].text = item.itemName;
                weaponsSprite[i].sprite = item.itemSprite; 

                weaponSlots[i].slotItem = item;
                weaponSlots [i].slotNumber = i;

                return;
            }
        }
    }
}
