using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public Text scoreText;
    private int score = 0;

    void Awake()
    {
        Instance = this;
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}