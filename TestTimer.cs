using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestTimer : MonoBehaviour
{
    public int timeRemainingInMinutes;

    public float timeRemainingInSeconds;

    public float gameTime = 20;

    private TextMesh timerText;



    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {

        timerText = GetComponent<TextMesh>();
        gameTime = timeRemainingInSeconds;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary> 
    void Update()
    {

        GameManager.Instance.TotalGameplay = gameTime - timeRemainingInSeconds;


        if (GameManager.Instance.TimerRunning)
        {
            if (timeRemainingInSeconds > 0)
            {
                timeRemainingInSeconds -= Time.deltaTime;
                DisplayTime(timeRemainingInSeconds);
            }
            else
            {
                timerText.text = "Pigs are comming :(";

                GameManager.Instance.SpawnEnemies = true;
                Debug.Log("Spawn enemies");
            }
        }


    }
    /// <summary>
    /// Convenience method to display the time in the TextMesh
    /// </summary>
    /// <param name="timeToDisplay"></param>
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        //Round minutes and seconds down
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = "Time Left: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }





}