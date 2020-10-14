using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{
    public Person father;
    public Person mother;
    public Person son;
    // Start is called before the first frame update
    void Start()
    {
        father = new Person();
        father.name = "Juan Gabriel";
        father.lastName = "Gomilas";
        father.secondLastName = "Salas";
        father.age = 28;
        father.isMarried = true;

        mother = new Person();
        mother.name = "Mar";
        mother.lastName = "Cardona";
        mother.secondLastName = "Aranda";
        mother.age = 20;
        mother.isMarried = true;
        mother.isFather = false;

        son = new Person();
        son.name = "Carlos";
        son.lastName = father.lastName;
        son.secondLastName = mother.lastName;
        son.age = 2;
        son.isFather = false;
        son.isMarried = false;


        print(father.name + " and " + mother.name + " has a son called: "
            + son.name + " who's " + son.age + " years old");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
