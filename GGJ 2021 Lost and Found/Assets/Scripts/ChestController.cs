using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public bool isOpen;
    public Item content;
    public Inventory playerInventory;
    public Animator animator;

    public void OpenChest()
    {
        if (!isOpen)
        {
            //add content to inventory
            //set the chest to open

            playerInventory.addItem(content);
            //playerInventory.currentItem = content;
            isOpen = true;
            animator.SetBool("isOpen", true);
            Debug.Log("Chest is now open...");
        }
    }

    public void emptyChest()
    {
        if (isOpen) 
        {
            playerInventory.currentItem = null;
        }
    }
}
