using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // public, private, protected

    public string  playerName = "Juan Gabriel";
     public int playerScore = 58;
    private int maxScore = 120;
     int playerAge = 28;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(playScore);
        Debug.Log(playerName);
        Debug.Log(playerScore + 12);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
