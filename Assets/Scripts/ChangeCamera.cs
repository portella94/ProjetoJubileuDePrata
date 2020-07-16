using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    
    void Start()
    {
        cam1.enabled = true;
    }
 
    public void switchcam() 
    {
        if(cam1.enabled)
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
        else
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }
        
    }
}
