using UnityEngine;

public class RayCasterF : MonoBehaviour
{
    public float distance;
    public LayerMask mask;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
        dir.z = 0;
        dir.Normalize();
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, distance, mask);
        if (hit.collider != null)
        {
            print("hit");
        }

        Color c = Color.green;
        if (hit.collider != null)
        {
            c = Color.red;
        }

        Debug.DrawRay(transform.position, dir * distance, c, 0.01f);
    }
}
