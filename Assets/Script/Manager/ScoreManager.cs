using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance;

    public static ScoreManager Instance {  get { return _instance; } }

    public int Score;

    public int BestScore;

    public Action OnScorePlus;
    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        } else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GameData gameData = SaveSystem.LoadGameManager();

        if(gameData != null)
        {
            BestScore = gameData.BestScore;
        }
       
        DeathManager.Instance.OnGameOver += OnGameOver;
        
    }

    private void OnDestroy()
    {
        DeathManager.Instance.OnGameOver -= OnGameOver;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScorePlus()
    {
        Score++;
    }

    public void OnGameOver()
    {
        if(BestScore < Score)
        {
            BestScore = Score;
        }
      

        Score = 0;

        SaveSystem.save(this);
    }
}
