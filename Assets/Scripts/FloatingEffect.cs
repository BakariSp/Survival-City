using UnityEngine;

public class FloatingEffect : MonoBehaviour
{
    public float amplitude = 0.05f; // Height of the floating effect
    public float frequency = 0.5f; // Speed of the floating effect

    public Vector3 startPos;

    void Start()
    {
        // Record the starting position of the object
        startPos = transform.localPosition;
    }

    void Update()
    {
        // Calculate the new Y position using a sine wave
        float newY = startPos.y + amplitude * Mathf.Sin(Time.time * Mathf.PI * frequency);
        transform.localPosition = new Vector3(startPos.x, newY, startPos.z);
    }

}
