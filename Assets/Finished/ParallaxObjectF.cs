using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class ParallaxObjectF : MonoBehaviour
{
    
    public Camera mainCamera;
    public float parallaxFactor;
    private Vector3 previousCameraPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        previousCameraPosition = mainCamera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = mainCamera.transform.position;
        Vector3 delta = previousCameraPosition - pos;
        this.transform.position += delta*parallaxFactor;
        previousCameraPosition = pos;
    }
}
