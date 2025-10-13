using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Search;
using Unity.VisualScripting;

public class Inventory : MonoBehaviour
{
    [Header("Game Manager")]
    [SerializeField] private GameManager gameManager;

    [Header("Inventory")]
    [SerializeField] private List<string> items = new List<string>();
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           AddItemToInventory("Generic Item");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RemoveItemFromInventory("Generic Item");
        }

    }

    public void AddItemToInventory (string itemName)
    { 
        items.Add(itemName); 
    }

    public void RemoveItemFromInventory (string itemName)
    {  
        items.Remove(itemName);
    }



}
