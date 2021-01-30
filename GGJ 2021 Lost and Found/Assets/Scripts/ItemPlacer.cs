using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlacer : MonoBehaviour
{

    public string placerDescription;
    public string placerID;
    public Item itemToBePlaced;
    public Inventory playerInventory;
    public bool isPlaced = false;
    public bool isGiven = false;

    public void placeItem(Item itemToPlace)
    {
        if(placerID == itemToPlace.itemID && !isPlaced)
        {
            playerInventory.items.Remove(itemToPlace);
            isPlaced = true;
        }
    }

    public void giveItem(Item itemToGive)
    {
        if (isPlaced && !isGiven)
        {
            playerInventory.items.Add(itemToGive);
            isGiven = true;
        }
    }
}
