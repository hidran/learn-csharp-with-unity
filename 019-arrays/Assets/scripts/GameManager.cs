using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public string[] player = new string[2] { "Scott", "John"};

    public int[] numbers;

    public string[] enemies2 = {
        "Bad guy1",
        "Bad guy2",
        "Cyclope",
        "Batman",
        "Car",
        "Boss"
    };
    // List<T> = new List<T>();
    List<string> newEnemies = new List<string>();
    /*List<string> newEnemies = new List<string>() { 
        "Bad guy",
        "Bad guy",
        "Cyclope",
        "Batman",
        "Car",
        "Boss"};
    "Bad guy","Cyclope","Car", "Boss"}
    */

    public GameObject[] enemies;
     void showData()
    {
        var currentEnemy = enemies2[2];

        print("Enemy at position 3 is " + currentEnemy);
        currentEnemy = enemies2[enemies2.Length -1];
        print("Last enemy " + currentEnemy);

        var currentNewEnemy = newEnemies[0];
        print("Current new enemy is " + currentNewEnemy);
        currentNewEnemy = newEnemies[newEnemies.Count -1];
        print("Last new enemy is " + currentNewEnemy);
    }
     void Awake()
    {
       

        // enemies2[0..5]
        // newEnemies =;
        List<string> enemies3 = new List<string>(enemies2);
        print("new enemies3 are " + enemies3.Count);
        newEnemies.AddRange(enemies2);
        newEnemies.Add("Black Monster");
        showData();
        print("new enemies are " + newEnemies.Count);
        enemies3.Remove("Bad guy");
        print("new enemies3 are " + enemies3.Count);
        
        if(enemies3.Contains("Bad guy"))
        {
            print("enemies3 still has a bad guy");
        }
        enemies3.Insert(2, "Good guy");
        enemies3.ForEach(print);
       
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
