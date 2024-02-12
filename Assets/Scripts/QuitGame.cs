using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ExitGame()
    {
        // Quit the application
        Application.Quit();

        // If running in the Unity editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}