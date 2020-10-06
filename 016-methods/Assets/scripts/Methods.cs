using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
     void Awake()
    {
        int number = 16;

        IsItEven(number);
        number = 17;
        IsItEven(number);
        IsItEven(23);
        HelloBeforeStartingTheGame();

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
        
    }
}
