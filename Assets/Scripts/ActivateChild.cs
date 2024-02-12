using UnityEngine;

public class ActivateChild : MonoBehaviour
{
    void Start()
    {
        // Iterate through all child GameObjects
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true); // Reactivate each child
        }
    }
}
