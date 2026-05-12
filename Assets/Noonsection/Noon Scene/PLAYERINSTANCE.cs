using System.IO;
using UnityEngine;
using UnityEngine.Rendering;

public class PLAYERINSTANCE : MonoBehaviour
{
    // Prefab to spawn
    public GameObject objectPrefab;

    // Maximum objects allowed
    public int maxObjects = 10;

    // Time between spawns
    public float spawnInterval = 1f;

    // Destroy after this many seconds
    public float destroyTime = 5f;

    private float timer;

    public int number1, number2;
    void Update()
    {
        /* timer += Time.deltaTime;

         // Spawn only after interval
         if (timer >= spawnInterval)
         {
             timer = 0f;

             // Check current spawned objects
             if (GameObject.FindGameObjectsWithTag("Spawned").Length < maxObjects)
             {
                 Vector2 spawnPos = new Vector2(
                     Random.Range(-5f, 5f),
                     Random.Range(-5f, 5f)
                 );

                 GameObject obj = Instantiate(objectPrefab, spawnPos, Quaternion.identity);

                 // Set tag
                 obj.tag = "Spawned";

                 // Destroy after time
                 Destroy(obj, destroyTime);
             }
         }*/

        Hello();
        AddNumber(5, 5);
      AddNumber(number1, number2);


        string returnvaule = GetPlayerName();
        Debug.Log("Player Name is " + returnvaule);// called function and store the return value in a variable and print it

        Debug.Log("Player Name is " + GetPlayerName()); // called function and directly print the return value without storing it in a variable


        string scoreResult = Score(number1);
        Debug.Log("Score Result: " + scoreResult);

        Debug.Log("Score Result: " + Score(50));

    }


    public void Hello()
    {

    Debug.Log("Hello World");

    }


    void AddNumber( int a, int b )
    {
        Debug.Log("Sum of Number is "+ (a + b) );
    }


    string GetPlayerName()
    {
        string PlayerName = "Subin";

        return PlayerName;
        //return "Subin";
    }


    string Score(int a)
    {
       if(a>100)
        {
            return "High Score";
        }
       else if(a>50)
        {
            return "Medium Score";
        }
       else
        {
            return "Low Score";
        }
    }


}

/*
void Update()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));

        Instantiate(objectPrefab, spawnPos, Quaternion.identity); 
    */