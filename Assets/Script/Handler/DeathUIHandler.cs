using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathUIHandler : MonoBehaviour
{

    public GameObject GameOverUI;

    public TextMeshProUGUI ScoreText;

    public TextMeshProUGUI BestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        DeathManager.Instance.OnGameOver += DeathUIOn;
    }

    private void OnDestroy()
    {
        DeathManager.Instance.OnGameOver -= DeathUIOn;
    }

    public void DeathUIOn()
    {
        GameOverUI.SetActive(true);
        ScoreText.text = ScoreManager.Instance.Score.ToString();
        BestScoreText.text = ScoreManager.Instance.BestScore.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
