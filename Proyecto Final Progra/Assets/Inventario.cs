using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{

    private bool inventoryEnabled;
    public GameObject inventory;
    private int allSlots;
    private int enabledSlots;
    private GameObject[] slot;
    public GameObject slotsHolder;
    public List<GameObject> Bolsa = new List<GameObject>();


    void Start()
    {
        allSlots = slotsHolder.transform.childCount;  
        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotsHolder.transform.GetChild(i).gameObject;
        }

    }
  


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) 
        {
        inventoryEnabled = !inventoryEnabled;
        }

        if (inventoryEnabled == true)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }

    }
}
