using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public string[] player = new string[2] { "Scott", "John"};

    public int[] numbers;

   /* public string[] enemies = {
        "Bad guy",
        "Bad guy",
        "Cyclope",
        "Batman",
        "Car",
        "Boss"
    };
   */
    public GameObject[] enemies;
     void Awake()
    {

        numbers = new int[10] ;
        numbers[0] = 4;
        player[0] = "Scott";
        player[1] = "John";
        print(enemies.Length);
        Debug.Log("Game started ");
        string enemy1 = "Bad guy";
        string enemy2 = "Cyclope";
        string enemy3 = "Batman";
        string enemy4 = "Car";
        string enemy5 = "Boss";

        // find enemies
        enemies = GameObject.FindGameObjectsWithTag("enemies");
        print("We have " + enemies.Length + " enemies");
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
