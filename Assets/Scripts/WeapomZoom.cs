using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapomZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    
    bool zoomInToggle = false;

    private void Update() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomInToggle == false)
            {
                zoomInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
            }
            else
            {
                zoomInToggle = false;
                fpsCamera.fieldOfView = zoomOutFOV;
            }
        }    
    }
}
