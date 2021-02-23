using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public List<Drop> inventory;


    private void Awake()
    {
        if (instance == null) instance = this;
        inventory = new List<Drop>();

    }

    private void Start()
    {
        /*inventory.Add(new Drop("b", 1));
        inventory.Add(new Drop("a", 1));
        inventory.Add(new Drop("c", 1));

        foreach (Drop drop in inventory)
        {
            Debug.Log(drop.name);
        }

        Debug.Log("Sorting");
        inventory.Sort();

        foreach (Drop drop in inventory)
        {
            Debug.Log(drop.name);
        }*/

    }
}
