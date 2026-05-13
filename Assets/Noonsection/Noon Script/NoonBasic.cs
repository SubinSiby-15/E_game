using UnityEngine;
using System.Collections;
using UnityEngine.Rendering.Universal;


public class NoonBasic : MonoBehaviour
{
 
    private Coroutine displayCoroutine;
    private Coroutine teleportCoroutine;

    public  Transform tragetPosition;
    public  Vector3 startPosition;



    private void Start()
    {
        startPosition = transform.position;

     
    }


    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Alpha1))

        {
            Debug.Log("Key 1 pressed");

            teleportCoroutine = StartCoroutine(Teleport());

            // displayCoroutine = StartCoroutine(Display());
        }


        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Key 2 pressed");
            teleportCoroutine = StartCoroutine(Re_Teleport());
           // StopCoroutine(displayCoroutine);
        }
          
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Debug.Log("Key 5 pressed and stopped all coroutine");
            StopAllCoroutines();
          
        }
        

    }

    IEnumerator Display()
    {
        Debug.Log("Hello World");
        yield return new WaitForSeconds(2f);
        Debug.Log("Welcome to Noon Section");
    }



    IEnumerator Teleport()
    {
        Debug.Log("Teleporting...");
        yield return null; // Wait for the next frame to ensure the teleportation happens after the current frame's updates
        transform.position = tragetPosition.position; // Teleport to the target position
    }
    IEnumerator Re_Teleport()
    {
        Debug.Log("ReTeleporting...");
        
        yield return new WaitForSeconds(2f);
        transform.position = startPosition; // Teleport back to the start position
    }
  


}
