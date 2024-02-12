using UnityEngine;
using TMPro; // Make sure to include the TextMeshPro namespace

public class GameManager : MonoBehaviour
{
    public GameObject scoreObject; // Object containing the script with scores
    public TextMeshProUGUI scoreText; // Reference to your TextMeshPro UI component

    private void Update()
    {
        if(scoreObject != null && scoreText != null)
        {
            // Access the script that contains the scores
            ScoreManager scoreManager = scoreObject.GetComponent<ScoreManager>();
            if(scoreManager != null)
            {
                // Update the TextMeshPro text
                // scoreText.text = "Score: " + scoreManager.score + "\nEnv Score: " + scoreManager.env_score;
                Debug.Log("text changed!");

                // Activate the TextMeshPro component if it's not active
                if(!scoreText.gameObject.activeSelf)
                {
                    scoreText.gameObject.SetActive(true);
                }
            }
        }
    }
}
