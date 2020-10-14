using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    Car myCar;
    private void Awake()
    {
        myCar = new Car();
        myCar.color = Color.green;
        myCar.make = "Lamborghini";
        myCar.hp = 240;
        myCar.model = "Aventador";

       Car neighborCar = new Car();
        myCar.color = Color.yellow;
        print("My car's color = " + myCar.color);
        print("My neihbor's car's color = " + neighborCar.color);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
