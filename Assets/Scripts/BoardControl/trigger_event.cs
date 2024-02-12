using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using UnityEngine;
using UnityEngine.UI;

public class trigger_event : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("cube"))
        {
            GetComponent<Image>().color = Color.blue;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("cube"))
        {
            GetComponent<Image>().color = Color.white;
        }
    }





    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("cube"))
        {
            if (other.GetComponent<XR_cube>() == null)
            {
                return;
            }

            if (!other.GetComponent<XR_cube>().isgrab)
            {
                if (other.GetComponent<XR_cube>().canBePlace)
                {
                    other.transform.position = transform.position;
                    other.transform.rotation = transform.rotation;
                    
                    other.GetComponent<XR_cube>().canBePlace = false;
                    other.transform.parent.GetComponent<Grabbable>().enabled = false;
                    other.transform.parent.GetComponent<HandGrabInteractable>().enabled = false;
                    other.transform.parent.SetParent(GameObject.Find("BoardComponents").transform);
                }
            }
        }  
    }
}
