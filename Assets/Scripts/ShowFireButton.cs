using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFireButton : MonoBehaviour
{
    private ScoreManager scoreManager;
    public GameObject fireButton;
    public GameObject failText;
    void Start()
    {
        scoreManager = transform.GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreManager.score > 100 && fireButton != null)
        {
            fireButton.SetActive(true);
        }

        if (scoreManager.env_score < 0)
        {
            failText.SetActive(true);
        }
    }
}
