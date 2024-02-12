using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    private Transform canvas_trans;
    void Start () 
    {
        canvas_trans = GameObject.Find("Canvas_main").transform;
    
        if ( canvas_trans == null)
        {
            Debug.Log("Canvas not initilized!");
        }
    }

    // Update is called once per frame
    public void setImage(bool isactive)
    {
        var canva = canvas_trans.GetComponent<canvasManager>();
        int xx = (int)canva.wh_ver.x;
        int yy = (int)canva.wh_ver.y;
        for (int i = 0; i < xx*yy; i++)
        {
            canvas_trans.GetChild(i).GetComponent<Image>().enabled = isactive;
        }
    }
}
