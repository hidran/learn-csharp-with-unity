using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Arithmetic binary operators: +, -, *, /,  % ( remainder)
 * Unary operators ++, --, -, +;
 * Compound assigments: +=, -= , *=, /=, %=
 */
public class Arithmetic : MonoBehaviour
{
    private ushort numberOfCoins = 0;
    private float applePrice = 2.5f;
    private float pearPrice = 3.5f;
    private float pocketMoney = 300f;
    private int numberOfApples = 10;
    private int numberOfPears = 10;

    private void Awake()
    {
        // binaryOperators();
        // unaryOperators();
        compoundAssignment();
    }

    private void compoundAssignment()
    {
        numberOfApples = numberOfApples + 1;
        Debug.Log("number of apples +1 : " + numberOfApples);
       numberOfApples += 5; // numberOfApples = numberOfApples +5;
        Debug.Log("number of apples +5 : " + numberOfApples);
        numberOfApples *= 2;
        Debug.Log("number of apples *2 : " + numberOfApples);
        numberOfApples /= 4;
        Debug.Log("number of apples /4 : " + numberOfApples);
        numberOfApples %= 3;
        Debug.Log("number of apples %3 : " + numberOfApples);
    }
    private void unaryOperators()
    {
        int myNumber = 4;
        Debug.Log(+myNumber);
         myNumber = -4;
        Debug.Log(+myNumber);
        Debug.Log(-myNumber);
        myNumber = 5;
        Debug.Log(-myNumber);
        Debug.Log(myNumber + "incremented =" + (++myNumber));
        Debug.Log(myNumber + "after being incremented" );
        Debug.Log(myNumber + "incremented =" + (myNumber++));
        Debug.Log(myNumber + "after being incremented");
        myNumber = 15;
        myNumber = ++myNumber;
        Debug.Log(myNumber);
        int myNewNumber = myNumber++;
        Debug.Log(myNewNumber);
        Debug.Log(myNumber);
        myNewNumber = ++myNumber;
        Debug.Log(myNewNumber);
        Debug.Log(myNumber);
        myNewNumber = --myNumber;
        Debug.Log(myNewNumber);
        Debug.Log(myNumber);
    }
    private void binaryOperators()
    {
        Debug.Log("Addition: 4+4 = " + (4 + 4));
        Debug.Log("Substraction: 14-4  = " + (14 - 4));
        Debug.Log("Multiplication: 4*4  = " + (4 * 4));
        Debug.Log("Division: 24/4  = " + (24 / 4));
        var div = (double)38 / 3;
        Debug.Log(" 38 / 3 = " + div);
        int remainder = 38 % 3;
        Debug.Log(" 38 % 3 = " + remainder);

        Debug.Log("36: Is it even? " + IsEven(36));
        Debug.Log("37: Is it even? " + IsEven(37));
    }
  private bool IsEven(int number)
    {
        return (number % 2) == 0;
    }
}
