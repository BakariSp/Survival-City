using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public GameObject solarEnergy;
    public GameObject building2;
    private ScoreManager scoreManager;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = transform.GetComponent<ScoreManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreManager.score < 20 && solarEnergy != null && solarEnergy.activeSelf != false)
        {
            solarEnergy.SetActive(false);
        }
        else if (scoreManager.score > 20 && solarEnergy != null && solarEnergy.activeSelf != true)
        {
            solarEnergy.SetActive(true);
        }

         if (scoreManager.score < 10 && building2 != null && building2.activeSelf != false)
        {
            building2.SetActive(false);
        }
        else if (scoreManager.score > 10 && building2 != null && building2.activeSelf != true)
        {
            building2.SetActive(true);
        }
    }
}
