using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public TreeGenerator treeGenerator;
    // public ScoreManager scoreManager;
    public void RestartScene()
    {
        // Get the current scene
        Scene currentScene = SceneManager.GetActiveScene();
        treeGenerator.GenerateTree(50, treeGenerator.scoreManager);

        // Reload the current scene
        SceneManager.LoadScene(currentScene.buildIndex);
    }


}
