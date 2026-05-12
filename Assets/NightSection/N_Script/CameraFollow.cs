using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;


   
    public Vector3 offset; // value (0,0) means distance between camera and player is 0 in x and y axis

    void LateUpdate()
    {

        if (player != null)
        {
       // Vector2 newPosition = new Vector2(player.position.x + Offset.x, player.position.y + Offset.y);
            // transform.position = new Vector2(newPosition.x, newPosition.y);


            transform.position = new Vector3(player.position.x + offset.x   , player.position.y + offset.y,transform.position.z);  


        }
    }
}

