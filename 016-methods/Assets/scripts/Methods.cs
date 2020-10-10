using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
   protected  void Awake()
    {
        int number = 17;

      bool  even = IsItEven(number);
        // var even = IsItEven(number);
        Debug.Log("============================================");
        if (even)
        {
            Debug.Log(number + " is even");
        } else
        {
            Debug.Log(number + "is odd");
        }
        Debug.Log("============================================");
        number = 17;
        IsItEven(number);
        IsItEven(23);
        HelloBeforeStartingTheGame();
        Debug.Log("============================================");
      int total =  SumNumbers(200, 300, '-');
        Debug.Log(" ============================================");
        Debug.Log("200 - 300 = " + total);
        total =  SumNumbers(20, 30, '*');
        Debug.Log("============================================");
        string message = string.Format("20 * 30 = {0:d}, {1}", total, "Hidran");
        Debug.Log(message);
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

   bool IsItEven( int num)
    {
        if (num % 2 == 0)
        {
            Debug.Log("Number " + num + " is Even");
            return true;
        }
       //return false;
        else
        {
            Debug.Log("Number " + num + "  is Odd");
            return false;
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
    int SumNumbers(int numberOne = 0, int numberTwo = 0,char opType = '+')
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
        return result;
      //  Debug.Log(numberOne + "" + opType + "" + numberTwo + " =" + result);
    }
}
