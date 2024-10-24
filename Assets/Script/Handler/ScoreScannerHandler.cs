using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScannerHandler : MonoBehaviour
{

    public AudioClip scoreSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            ScoreManager.Instance.Score++;
            ScoreManager.Instance.OnScorePlus?.Invoke();
            SfxManager.Instance.PlaySoundFXClip(scoreSound, this.transform);
        }
    }
}
