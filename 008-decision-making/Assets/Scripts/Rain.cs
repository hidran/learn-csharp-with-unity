using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public bool isItGoingToRain = false;

    public bool amIanEmployee = true;

    public int age = 18;

    public int money = 10;

    public bool fatherIsARockStar = true;

    public int applePrice = 8;
    public int discount = -5;
    public int pearPrice = 3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log((3*applePrice + 4*pearPrice) + discount);
       
        amIanEmployee = !amIanEmployee;

        if (isItGoingToRain) {
            Debug.Log("I should take my umbrella");

            Debug.Log("The value of isItGoingToRain is =" + isItGoingToRain);
        }
        else
        {
            Debug.Log("I don't need to take my umbrella");

            Debug.Log("The value of isItGoingToRain is =" + isItGoingToRain);
        }

        if (!amIanEmployee)
        {
            Debug.Log("No, you are not an employee");
        } else
        {
            Debug.Log("Yes, you are  an employee");
        }

        if ((age >= 18 && money > 30)  || fatherIsARockStar)
        {
           // Debug.Log("Ok, you can grab a beer");
           
            Debug.Log(" you can have fun in this party");
   
        }
        else
        {
            Debug.Log("Sorry boy!,Go home and play some Pokémon!");

        }
        /*
          if(age >= 18)
          {
              Debug.Log("Ok, you can grab a beer");
              if(money > 30)
              {
                  Debug.Log("Ok, you can have fun in this party");
              } else
              {
                  Debug.Log("Gome home, poor boy!");
              }

          } else
          {
              Debug.Log("Sorry!, you can grab only a coke!");


          }
        */

    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
