using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlots : MonoBehaviour
{

    public ScriptableItem slotItem;
    public int slotNumber;
    public GameObject inspectionWindow;
    public Image inspectionImage;
    public Text inspectionName;
    public Text inspectionPrice;
    public Text inspectionDescription;
    public Button deleteButton;
    public Button closeButton;

    public void InspectItem()
    {
        if(slotItem != null && inspectionWindow.activeInHierarchy == false)
        {
            inspectionWindow.SetActive(true);
            closeButton.onClick.AddListener(Closeinspection);
            deleteButton.onClick.AddListener(RemoveItem);

            inspectionImage.sprite = slotItem.itemSprite;
            inspectionName.text = slotItem.itemName;
            inspectionPrice.text = slotItem.itemPrice.ToString();
            inspectionDescription.text = slotItem.itemDescription;           

        }

    }

    public void RemoveItem()
    {
        if(InventoryManager.instance.weapons [slotNumber] != null)
        {
            InventoryManager.instance.weapons [slotNumber] = null;
            InventoryManager.instance.weaponsName[slotNumber].text = " ";
            InventoryManager.instance.weaponsSprite[slotNumber].sprite = null;
        }

        slotItem = null;

        
    }

    public void Closeinspection()
    {
        deleteButton.onClick.RemoveListener(RemoveItem);
        inspectionWindow.SetActive(false);
    }
}
