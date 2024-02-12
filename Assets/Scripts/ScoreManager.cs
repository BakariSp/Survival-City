using UnityEngine;
using TMPro; // Include the TextMeshPro namespace

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton instance

    public int score = 0;
    public int env_score = 0;

    // TextMeshProUGUI element to display score
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI env_scoreText;
    public int incrementScore = 5;

    void Awake()
    {
        // Singleton pattern
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Optional: Keep the score manager across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    public void SubtractScore(int points)
    {
        score -= points;
        UpdateScoreDisplay();
    }

    public void AddEvnScore(int points)
    {
        env_score += points;
        UpdateScoreDisplay();
    }

    public void SubtractEvnScore(int points)
    {
        env_score -= points;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "" + score;
        }

        if (env_scoreText != null)
        {
            env_scoreText.text = "" + env_score;
        }
    }
}
