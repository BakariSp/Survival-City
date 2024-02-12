using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildEngine : MonoBehaviour
{
    public GameObject boardObject; // Assign in the inspector
    public GameObject engine;
    private bool shouldMove = false;
    private Vector3 targetPosition;

    public void CityFly()
    {
        // Activate the GameObject named "eng"
        // GameObject eng = GameObject.Find("eng");
        // if (eng != null)
        // {
        //     eng.SetActive(true);
        // }

        GameObject boardComponents = GameObject.Find("BoardComponents");
        if (engine != null)
        {
            Instantiate(engine, boardComponents.transform);
        }
     
        if (boardComponents != null)
        {
            boardComponents.GetComponent<FloatingEffect>().enabled = true;
        }

        // Set the target position 0.3 units higher in the Y direction
        targetPosition = boardObject.transform.position + new Vector3(0, 0.3f, 0);

        // Start the movement
        shouldMove = true;

        
    }

    void Update()
    {
        // If shouldMove is true, move towards the target position
        if (shouldMove)
        {
            // Adjust the speed as necessary. Higher values make the movement faster.
            float speed = 2.0f; 
            boardObject.transform.position = Vector3.Lerp(boardObject.transform.position, targetPosition, speed * Time.deltaTime);

            // Optionally, you can stop moving when close to the target position
            if (Vector3.Distance(boardObject.transform.position, targetPosition) < 0.01f)
            {
                shouldMove = false;
            }
        }
    }
}
