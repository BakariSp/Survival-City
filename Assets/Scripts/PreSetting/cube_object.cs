using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public struct object_cube
{
    public GameObject cu;

}

[CreateAssetMenu(fileName = "new cube", menuName = "pete/new cube")]
public class cube_object : ScriptableObject
{

    public List<object_cube> object_Cubes = new List<object_cube>();

}
