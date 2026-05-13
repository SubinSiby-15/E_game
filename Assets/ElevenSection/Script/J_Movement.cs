using UnityEngine;

public class J_Movement : MonoBehaviour
{

    public float J_Speed = 5f;
    
    public float direction = 1f;


    void Update()
    {

       // transform.Translate( J_Speed * Time.deltaTime, 0, 0 );




       // transform.Translate(Vector2.up * J_Speed * Time.deltaTime * direction );


        transform.Translate(Vector2.up * J_Speed * Time.deltaTime * direction);
        Debug.Log("object  Name Is " + name);


        if(name== "WhiteCircle")
        {
            transform.Translate(Vector2.up * J_Speed * Time.deltaTime * direction);
        }

        if(name== "BlackCircle")
        {
            transform.Translate(Vector2.left * J_Speed * Time.deltaTime * direction);
        }

    }
}
