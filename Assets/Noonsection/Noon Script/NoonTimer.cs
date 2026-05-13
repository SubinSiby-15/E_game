using UnityEngine;
using TMPro;
using Unity.IntegerTime;

public class NoonTimer : MonoBehaviour
{
    public float time_count = 0;

    public TextMeshProUGUI timertext;


    private void Update()
    {
        time_count-=Time.deltaTime;
        DiaplayTime(time_count);
        if(time_count<5)
        {
             timertext.color = Color.red;
           // if(time_count<0)
              //  Time.timeScale = 0f; // Pause the game when the timer reaches zero
        }
    }



    public void DiaplayTime( float time)
    {
       // int minutes = Mathf.FloorToInt(time / 60);
        //int seconds = Mathf.FloorToInt(time % 60);
      //  timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);


        int hour = Mathf.FloorToInt(time / 3600);
        int minutes = Mathf.FloorToInt((time % 3600) / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timertext.text = string.Format("{0:00}:{1:00}:{2:00}", hour, minutes, seconds);
    }

}
