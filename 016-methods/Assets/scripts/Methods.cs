using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
   protected  void Awake()
    {
        int number = 16;

        IsItEven(number);
        number = 17;
        IsItEven(number);
        IsItEven(23);
        HelloBeforeStartingTheGame();
        Debug.Log("============================================");
        SumNumbers(200, 300, '-');
        Debug.Log("============================================");
        SumNumbers(20, 30, '*');
        Debug.Log("============================================");
        SumNumbers(  4,5);
        Debug.Log("============================================");
        //SumNumbers("12", "13");
        SumNumbers();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Class just started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void IsItEven( int num)
    {
        if (num % 2 == 0)
        {
            Debug.Log("Number " + num + " is Even");
        }
        else
        {
            Debug.Log("Number " + num + "  is Odd");
        }
    }
   void HelloBeforeStartingTheGame()
    {
        // TODO: Implement Hello Method

        //if (true)
        //{
        //}
        //else
        //{
        //}



    }
    void SumNumbers(int numberOne = 0, int numberTwo = 0,char opType = '+')
    {
        int result = 0;
        if (opType == '+')
        {
            result = numberOne + numberTwo;
        } else if(opType == '-')
        {
            result = numberOne - numberTwo;
        } else if(opType == '*')
        {
            result = numberOne * numberTwo;
        }
        
        Debug.Log(numberOne + "" + opType + "" + numberTwo + " =" + result);
    }
}
