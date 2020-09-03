using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Built-in data types
public class Builtin : MonoBehaviour
{
    private string myName = "Hidran";
    private bool isSmoker = false;

    public sbyte age = 127;
    public double price ;
    public char leftKey = 'A';
    /*
     * whole number types : sbyte, byte, ushort, short, int, uint, long, ulong, double
     * decimal numbers : float, double, decimal
     */
    void Start()
    {

        price = 1/3d; // 0.3333
        Debug.Log(price.ToString("0.000000000"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
