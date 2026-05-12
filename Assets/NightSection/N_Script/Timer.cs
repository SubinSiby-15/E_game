using UnityEngine;
using TMPro;
using System.Collections;
public class Timer : MonoBehaviour
{

     public float timecounter = 100f;
     public TextMeshProUGUI timerText;

    Coroutine myexamplecoroutine;

    private void Start()
    {
        StartCoroutine(TimerCo());
    }



    private void Update()
    {
        //timecouuntup-= Time.deltaTime;
      //  UpdateTimer(timecouuntup);


    }

     IEnumerator TimerCo()
    {
    while(timecounter>=0)
        {
           UpdateTimer(timecounter);
            yield return new WaitForSeconds(1f);
            timecounter--;
        }
    Debug.Log("Time's up!"); // Log a message to the console when the timer reaches zero for debugging purposes.
    }



    
    public void UpdateTimer(float deltaTime)
    { 
        int minutes = Mathf.FloorToInt(deltaTime / 60f);  //5/60 = 0.0833 .60/60 = 1
        int secounds = Mathf.FloorToInt(deltaTime % 60f);  //5%60 = 5. 60%60 = 0
        timerText.text = string.Format("{0:00}:{1:00}", minutes, secounds);

    }

    

}
