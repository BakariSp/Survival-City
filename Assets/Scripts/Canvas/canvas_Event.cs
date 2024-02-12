using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas_Event : MonoBehaviour
{
    [SerializeField]
    private cube_object cube_;
    [SerializeField]
    private Transform spawnPos;


    private Transform This_tran;

    private Button object1;
    private Button object2;


 


    private void Start()
    {
        This_tran = transform;
        // object1= This_tran.GetChild(0).GetComponent<Button>();
        // object2= This_tran.GetChild(1).GetComponent<Button>();

        // object1.onClick.AddListener(() => { objexone_event(0); });
        // object2.onClick.AddListener(() => { objexone_event(1); });


    }
    /// <summary>
    /// object event
    /// </summary>
    public void objexone_event(int i)
    {
        GameObject gam = Instantiate(cube_.object_Cubes[i].cu, spawnPos.position+new Vector3(0,0.3f,0), Quaternion.identity);
    }



}
