using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIHandler : MonoBehaviour
{

    public TextMeshProUGUI ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.Instance.OnScorePlus += OnScorePlus;
    }

    private void OnDestroy()
    {
        ScoreManager.Instance.OnScorePlus -= OnScorePlus;
    }

    void OnScorePlus()
    {
        ScoreText.text = ScoreManager.Instance.Score.ToString();
    }
}
