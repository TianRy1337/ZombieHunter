using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeapomZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsCotroller;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;

    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = .5f;
    
    
    public bool zoomInToggle = false;
    private void OnDisable() 
    {
        ZoomOut();
    }


    private void Update() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }    
    }

    private void ZoomIn()
    {
        zoomInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsCotroller.mouseLook.XSensitivity = zoomInSensitivity;
        fpsCotroller.mouseLook.YSensitivity = zoomInSensitivity;
    }
    private void ZoomOut()
    {
        zoomInToggle = false;
        fpsCamera.fieldOfView = zoomOutFOV;
        fpsCotroller.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsCotroller.mouseLook.YSensitivity = zoomOutSensitivity;
    }
}
