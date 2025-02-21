using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int direction;
    public float distance;
    public LayerMask mask;
    
    private Rigidbody2D rb;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = -1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(direction, -1, 0);
        dir.Normalize();
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, distance, mask);
        if (hit.collider == null)
        {
            direction *= -1;
        }
        
        //visualize
        Color c = Color.green;
        if (hit.collider == null)
        {
            c = Color.red;
        }
        Debug.DrawRay(this.transform.position, dir * distance, c,0.01f);

        Vector3 movement = rb.linearVelocity;
        movement.x = direction * speed;
        rb.linearVelocity = movement;

    }
}
