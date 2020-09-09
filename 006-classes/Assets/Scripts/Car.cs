using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {
    public string make = "FIAT";
    public string model = "500";
    // public string color = "Red";
    public Color color = Color.red;
    public int hp = 150;
    private int numberOfPistons = 3;

    // Start is called before the first frame update
    void Start () {
        Debug.Log ("Start");
    }

    // Update is called once per frame
    void Update () {

if(numberOfPistons > 3){

}

        if (Input.GetKeyDown (KeyCode.C)) {
            Debug.Log ("About to start my " + " " + make + " " + model);
            StartCar ();
        }

        if (Input.GetKeyDown (KeyCode.S)) {
            Debug.Log ("About to stop my " + " " + make + " " + model);
            StopCar ();
        }
    }
    void StartCar () {
        Debug.Log ("Brrrrrrrrrrrrrrummmmmmmmmmm");
    }
    void StopCar () {
        Debug.Log ("The car was stopped");
    }

}