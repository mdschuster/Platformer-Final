using UnityEngine;

public class ParallaxObject : MonoBehaviour
{

    public Camera parallaxCamera;
    public float parallaxFactor;
    
    private Vector3 previousCameraPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        previousCameraPosition=parallaxCamera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = parallaxCamera.transform.position; //camera's current position
        Vector3 delta = previousCameraPosition - pos;
        this.transform.position += delta* parallaxFactor;
        previousCameraPosition = pos;
    }
}
