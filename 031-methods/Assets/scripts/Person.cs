using System;

using UnityEngine;
public class Person 
{
    public string name = "";
    public string lastName = "";
    public string secondLastName = "";
    public int age = 0;
    public string address = "";
    public bool isMarried = false;
    public bool isFather = true;
    public Car car;
    public  Person spouse ;

     public bool IsMarriedTo(Person spouse)
    {
        if(spouse == null)
        {
            throw new ArgumentException("spouse parameter cannot be null");
        }
       
        Debug.Log(spouse.name);
        return this.spouse == spouse ; 
    }
   
}
