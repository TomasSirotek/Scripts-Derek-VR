using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager
{
    private static GameManager _instance = new GameManager();
    private GameState gameStatus = GameState.PLAYING;
    public bool timerRunning = false;

    public int numberOfAgents = 0;
    public int numberOfStations  = 0;
    public int numberOfPoliti  = 0;
    public bool spawnEnemies = false;
    public bool spawnWinReward = false;
    public float totalGameTime = 0;
    public enum GameState
    {
        PLAYING = 0,
        WON = 1,
        LOST = -1
    }

    public GameState GameStatus
    {
        get { return gameStatus; }
        set { gameStatus = value; }
    }

    public float TotalGameplay
    {
        get { return totalGameTime; }
        set { totalGameTime = value; }
    }


    public bool TimerRunning
    {
        get { return timerRunning; }
        set { timerRunning = value; }
    }

    public int NumberOfAgents
    {
        get { return numberOfAgents; }
        set { numberOfAgents = value; }
    }
    public int NumberOfPolice
    {
        get { return numberOfPoliti; }
        set { numberOfPoliti = value; }
    }

    public int NumberOfStations
    {
        get { return numberOfStations; }
        set { numberOfStations = value; }
    }
   

      public bool SpawnEnemies
    {
        get { return spawnEnemies; }
        set { spawnEnemies = value; }
    }


    public bool SpawnReward
    {
        get { return spawnWinReward; }
        set { spawnWinReward = value; }
    }

    
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("created Singleton....");
                _instance = new GameManager();
            }

            return _instance;
        }
    }
    
    private GameManager() { }


    void Awake()
    {
        _instance = this;
    }
}