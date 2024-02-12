using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class XR_cube : MonoBehaviour
{
    //verfiy
    [Header("is being grabbed?")]
    public bool isgrab = false;
    [Header("can be constructed?")]
    public bool canBePlace = true;
    public void set_ster(bool islte)
    {
        isgrab = islte;
    }

    private Transform canvas_trans;


    private void Start()
    {
        canvas_trans = GameObject.Find("Canvas_main").transform;
    }

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

    // public 


    /*  private Image image;
      [SerializeField]
      private Color image_Color = Color.blue;

      private void OnTriggerEnter(Collider other)
      {
          if(other.CompareTag("image"))
          {
              image=other.GetComponent<Image>();
              image.color = image_Color;
          }
      }
      private void OnTriggerExit(Collider other)
      {
          if (other.CompareTag("image"))
          {
              image.color = Color.white;

          }
      }*/

}
