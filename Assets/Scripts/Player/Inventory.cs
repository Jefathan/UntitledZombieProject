//--------------------------------------------------------------------------------------
// Purpose: 
//
// Description: 
//
// Author: Thomas Wiltshire
//--------------------------------------------------------------------------------------

// Using, etc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------------------------------------------------------
// Inventory object. Inheriting from MonoBehaviour.
//--------------------------------------------------------------------------------------
public class Inventory : MonoBehaviour
{




    public int m_nPoints;
    public bool[] m_abFull;
    public GameObject[] m_agInventory;




    //--------------------------------------------------------------------------------------
    // initialization.
    //--------------------------------------------------------------------------------------
    void Awake()
    {
        // for each gameobject in the inventory
        //for (int i = 0; i < m_agInventory.Length; i++)
        //{
            // set each bool in the array to true.
            //m_abFull[i] = true;
        //}
    }
}
