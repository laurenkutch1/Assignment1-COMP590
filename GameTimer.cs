using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeLeft = 30f;
    public TMP_Text timerText;
    public TMP_Text gameOverText;

    void Start()
    {
        gameOverText.text = "";
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Ceil(timeLeft);
        }
        else
        {
            timeLeft = 0;
            timerText.text = "TIME'S UP!";
            gameOverText.text = "GAME OVER\nFinal Score: " + ScoreManager.Instance.GetScore();
        }
    }
}