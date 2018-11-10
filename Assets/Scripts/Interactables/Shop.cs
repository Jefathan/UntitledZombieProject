﻿//--------------------------------------------------------------------------------------
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




    //--------------------------------------------------------------------------------------
    // initialization.
    //--------------------------------------------------------------------------------------
    new void Awake()
    {
        // Run the base awake
        base.Awake();

        // deactivate the shop canvas
        m_gCanvasObject.SetActive(false);
    }

    //--------------------------------------------------------------------------------------
    // Update: Function that calls each frame to update game objects.
    //--------------------------------------------------------------------------------------
    void Update()
    {
        // If the interaction button or exc is pressed.
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // turn off interaction and set canvas to inactive
            m_bInteracted = false;
            m_gCanvasObject.SetActive(false);
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

        // activate the shop canvas
        m_gCanvasObject.SetActive(true);
    }
}