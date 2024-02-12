using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandController : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == null)
        {
            return;
        }
        // Check if the collided object is the tree
        if (other.gameObject.CompareTag("Tree")) // Make sure your tree GameObject has the tag "Tree"
        {
            other.gameObject.SetActive(false);
            // Destroy(); // Destroy the tree
            scoreManager.AddScore(scoreManager.incrementScore);
            scoreManager.SubtractEvnScore(scoreManager.incrementScore);
        }
    }
}
