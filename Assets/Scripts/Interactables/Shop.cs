//--------------------------------------------------------------------------------------
// Purpose:
//
// Description: 
//
// Author: Thomas Wiltshire
//--------------------------------------------------------------------------------------

// using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------------------------------------------------------
// Shop object. Inheriting from Interactable.
//--------------------------------------------------------------------------------------
public class Shop : Interactable
{





    public GameObject m_gCanvasObject;
    private Inventory m_sInventory;
    private bool m_bShopActive = false;







    //--------------------------------------------------------------------------------------
    // initialization.
    //--------------------------------------------------------------------------------------
    new void Awake()
    {
        // Run the base awake
        base.Awake();

        // deactivate the shop canvas
        m_gCanvasObject.SetActive(false);

        // get the shop inventory
        m_sInventory = GetComponent<Inventory>();
    }

    //--------------------------------------------------------------------------------------
    // Update: Function that calls each frame to update game objects.
    //--------------------------------------------------------------------------------------
    void Update()
    {
        // run the shop
        RunShop();

        // If the interaction button or exc is pressed.
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // turn off interaction and set shop to closed
            m_bInteracted = false;
            m_bShopActive = false;
        }
    }

    //--------------------------------------------------------------------------------------
    // InteractedWith: override function from base class for what Interactable objects do 
    // once they have been interacted with.
    //--------------------------------------------------------------------------------------
    protected override void InteractedWith()
    {
        // Run the base interactedWith function.
        base.InteractedWith();

        // Shop Enabled
        m_bShopActive = true;
        m_gCanvasObject.SetActive(true);
    }

    //--------------------------------------------------------------------------------------
    // ShopOpen: 
    //--------------------------------------------------------------------------------------
    private void RunShop()
    {
        // If the shop is open
        if (m_bShopActive)
        {
            //// for each gameobject in the inventory
            //for (int i = 0; i < m_sInventory.m_abFull.Length; i++)
            //{
            
            //}
        }

        else
        {
            // closed the shop canvas
            m_gCanvasObject.SetActive(false);
        }
    }
}