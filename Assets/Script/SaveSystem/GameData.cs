using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class GameData
{
    public int BestScore;

    public GameData(ScoreManager scoreManager)
    {

        BestScore = scoreManager.BestScore;

    }
}
