using UnityEngine;
using System.Collections;

public class TreeGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject tree;
    public ScoreManager scoreManager;
    private Transform basetransform;
    public int treeCount = 50;
    public int generateCount = 5;
    public float generateTime = 1.0f;

    // Define the range for tree placement
    public float rangeX = 0.2f; // Range on X-axis
    public float rangeZ = 0.25f; // Range on Z-axis

    void Start()
    {
        basetransform = GameObject.Find("TreesBase").transform;
        if (tree != null && basetransform!= null)
        {
            GenerateTree(treeCount, scoreManager);
            // StartCoroutine(GenerateTrees(generateCount));
        }
        else
        {
            Debug.LogError("Tree or basetransform is not assigned in the Inspector");
        }
    }

    void Update()
    {
        if (Random.Range(0f, 10f) < 0.02)
        {
            GenerateTree(generateCount, scoreManager);
        }
    }

    // IEnumerator GenerateTrees(int Count)
    // {
    //     GenerateTree(Count, scoreManager);
    //     yield return new WaitForSeconds(generateTime);
    // }

    public void GenerateTree(int Count, ScoreManager scoreManager)
    {
        for (int i = 0; i < Count; i++)
        {
            // Generate a random position within the defined range
            Vector3 randomPosition = basetransform.position + new Vector3(
                Random.Range(-rangeX, rangeX), 
                0f, // Assuming you want to keep the Y position the same as the basetransform
                Random.Range(-rangeZ, rangeZ)
            );

            // Instantiate the tree at the random position
            GameObject newTree = Instantiate(tree, randomPosition, Quaternion.identity);
            newTree.transform.SetParent(basetransform);
            scoreManager.AddEvnScore(scoreManager.incrementScore);

            // Wait for 5 seconds
        }
    }
}
