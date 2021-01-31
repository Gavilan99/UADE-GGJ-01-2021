using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlacer : MonoBehaviour
{

    public string placerDescription;
    public string placerID;
    public Item itemToBePlaced;
    public Inventory playerInventory;
    public SpriteRenderer silhouette; //Oboete nai koto mo takusan atta darou
    public Sprite itemPlaced;
    public bool isPlaced = false;
    public bool isGiven = false;
    
    

    public void placeItem(Item itemToPlace)
    {
        if(placerID == itemToPlace.itemID && !isPlaced)
        {
            playerInventory.items.Remove(itemToPlace);
            Debug.Log("Lo saque");
            isPlaced = true;
            silhouette.sprite = itemPlaced;
            GetComponent<Collider2D>().isTrigger=false;
            Debug.Log("Lo hice fisico");
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
