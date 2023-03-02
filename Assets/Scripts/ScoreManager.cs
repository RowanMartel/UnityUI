using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    TMPro.TMP_Text ScoreText;
    int score;
    int Score
    {
        get { return score; }
        set
        {
            score = value;
            ScoreText.text = "Score: " + score.ToString();
        }
    }

    void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<TMPro.TMP_Text>();
        ScoreText.text = "Score: " + 0;
    }

    public void ModifyScore(int modifier)
    {
        Score = Mathf.Clamp(Score + modifier, 0, 999);
    }
}