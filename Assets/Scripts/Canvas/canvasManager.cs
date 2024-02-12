using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasManager : MonoBehaviour
{

    private Transform canvas_Tran;

    [SerializeField]
    private GameObject box_Trigger;
    [SerializeField]
    [Header("dimensions")]
    public Vector2 wh_ver;




    private void Start()
    {
        canvas_Tran =transform;

        for (int i = 0; i < wh_ver.x; i++)
        {
            for (int j = 0; j< wh_ver.y; j++)
            {
                var obje = Instantiate(box_Trigger, transform);
                obje.transform.SetParent(canvas_Tran);
            }
        }
    }



}
