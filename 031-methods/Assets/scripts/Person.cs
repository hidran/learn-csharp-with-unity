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
    public Person spouse;
    public Person()
    {
        Debug.Log("Creating a new object with the default constructor");
        age = 2;
    }
    public Person(string name, string lastname,
    string secondlastname,
    Person spouse,
     int age = 2)
     : this(name, lastname, age)
    {
        Debug.Log("Creating a new object with the default constructor3");
        this.secondLastname = secondlastname;
        lastName = lastname;
        age = 2;
    }
    public Person(string name, string lastname, int age = 2) : this(name, lastname)
    {
        Debug.Log("Creating a new object with the default constructor2");
        //  this.name = name;
        //  lastName = lastname;
        age = 2;
    }
    public bool IsMarriedTo(Person spouse)
    {
        if (spouse == null)
        {
            throw new ArgumentException("spouse parameter cannot be null");
        }

        Debug.Log(spouse.name);
        return this.spouse == spouse;
    }

}
