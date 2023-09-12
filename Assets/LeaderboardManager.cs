using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI[] topScores;

    public float timeRemaining = 72;
    public bool timerIsRunning;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }
    
    void Update()
    {
        if (!timerIsRunning) return;
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            Debug.Log("Time has run out!");
            timeRemaining = 0;
            timerIsRunning = false;
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        var text = $"{minutes:00}:{seconds:00}";
        
        Debug.Log(text);
        topScores[0].text = text;
    }
}
