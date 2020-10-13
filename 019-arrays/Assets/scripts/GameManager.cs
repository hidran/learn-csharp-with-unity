using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Object = System.Object;

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

    ArrayList userInfo = new ArrayList()
    {
        "Hidran Arias",
        48,
        "Turin",
        "Italy",
        true
    };
    List<Object> userInfo2 = new List<Object>();
    public GameObject[] enemies;
    public Hashtable personalInfo = new Hashtable();
    public Dictionary<string, string> spanishNumbers = new Dictionary<string, string>()
    {
        {"one", "uno" },
         {"two", "dos" }
    };

    void PopulateNumbers()
    {
        spanishNumbers["two"] = "Dos";
        spanishNumbers["three"] ="tres";
        spanishNumbers.Add("four", "cuatro");

        if (!spanishNumbers.ContainsKey("five"))
        {
            spanishNumbers.Add("five", "cinco");
            print("five in Spanish is " + spanishNumbers["five"]);
        }
    }
        void PopulatePersonalInfo()
    {
        var myObject = GameObject.Find("Sphere");
        personalInfo.Add("fullname", "Juan Gabriel");
        personalInfo.Add("age", 28);
        personalInfo.Add("object", myObject);
        personalInfo.Add("nickname", "Joanby");
        personalInfo.Add(10, "Level");
        print(personalInfo[10]);
        print("My fullname is " + personalInfo["fullname"]);
        var nickname = (string) personalInfo["nickname"];
        print("My nickname is " + nickname);
        if (personalInfo.Contains("age"))
        {
            print("I am " + personalInfo["age"] + " years old");
        }
        if (personalInfo.ContainsValue(myObject))
        {
            print("I have a " + myObject.tag);
        }
    }
    void PopulateUserInfo()
    {
        userInfo2.Add("Juan Gabriel");
        userInfo2.Add("Joanby");
        userInfo2.Add(28);
        userInfo2.Add(GameObject.Find("Sphere"));
        print("Item at position 3 is " + userInfo2[3].GetType());
        var userObject = (GameObject) userInfo2[3];
        print("Item at position 3 is " + userObject.tag);
    }
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
     void ShowEnemies()
    {
        int count = 0;
        foreach( var enemy in enemies2)
        {
            print( count + " - " + enemy);
            count++;
        }
     
    }
    void ShowUserInfo()
    {
        int wCount = 20;
        while (wCount < 10)
        {
            print("printed with while loop: " + wCount);
            wCount++;
        }
        wCount = 0;
        do
        {
            print("printed with while reverse loop: " + wCount);
            wCount--;
        }
        while (wCount > 0);
        wCount = 1;
        while (true)
        {
            if(wCount %4 == 0 && wCount%400 == 0)
            {
                print(wCount + " is a leap year");
                break;
            }
            wCount++;
        }

        for(int i = 0; i<100 ; i++ )
        {
            if (i == 69)
            {
                break;
            }
            if ( i%2 != 0)
            {
                continue;
            }
            print("i = " + i);
           
        }
        int j = 0;
        for (; ; ){
            if (j > 9)
            {
                break;
            }
            print("j = " + j);
            
            j++;
        }
        int count = 0;
        // 5 =  0 1 2 3 4
        int counter = userInfo.Count;
        print("USER INFO WITH FOR LOOP");
        for( count = 0; count < counter; count++)
        {
            print(count + " - " + userInfo[count]);
        }
        var test = (string) userInfo[2];

        count = 0;
        foreach (var info in userInfo)
        {
            print(count + " - " + info);
            count++;
           
        }

    }
    void ShowUserInfo2()
    {
        int count = 0;
        foreach (var info2 in userInfo2)
        {
            print(count + " - " + info2);
            var test = info2;
            count++;
        }
    }

    
        void ShowDictHashTable()
            {
             foreach( var k in personalInfo.Keys)
            {
                print(k + " is = " + personalInfo[k]);
            }
        Debug.Log("=================DICTIONARY ENTRY=========================");
        foreach (DictionaryEntry element in personalInfo)
        {
            print(element.Key + " is = " + element.Value);
        }
        Debug.Log("=================DICTIONARY KeyValuePair=========================");

        foreach (KeyValuePair<string,string> number in spanishNumbers)
        {
            print( number.Key.ToUpper() +  " is = " + number.Value);
        }
    }
    void Awake()
    {
        Debug.Log("=================SHOW USERINFO=========================");
        ShowUserInfo();
        Debug.Log("==========================================");
        return;
        Debug.Log("=================SHOW USERINFO=========================");
        ShowUserInfo();
        Debug.Log("==========================================");

        Debug.Log("=================SHOW ENEMIES=========================");
        ShowEnemies();
        Debug.Log("==========================================");
        PopulateNumbers();
        Debug.Log("==========================================");
        PopulatePersonalInfo();
        Debug.Log("==========================================");
        PopulateUserInfo();
        Debug.Log("==========================================");
            Debug.Log("===============SHOW PERSONAL INFO===========================");
            ShowDictHashTable();
            Debug.Log("==========================================");
            Debug.Log("=================SHOW USERINFO2=========================");
        ShowUserInfo2();
        Debug.Log("==========================================");

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
