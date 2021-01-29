﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// WORK IN PROGRESS
public class Inventory : MonoBehaviour
{
    public Item currentItem;
    public List<Item> items = new List<Item>();


    public void addItem(Item itemToAdd)
    {
        if (!items.Contains(itemToAdd))
        {
            items.Add(itemToAdd);
        }
        else
        {
            Debug.Log("Object allready in inventory");
        }
    }

}