using UnityEngine;

public class EnemyF : MonoBehaviour
{
    public float speed;
    public float castLength;
    public LayerMask mask;
    private float direction;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(direction, -1, 0);
        vec.Normalize();
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, vec, castLength, mask);
        if (hit.collider == null)
        {
            direction *= -1;
        }
        
        
        //visualize
        Color c = Color.green;
        if (hit.collider != null) c = Color.red;
        Debug.DrawRay(this.transform.position,vec*castLength,c,0.01f);

        Vector3 velocity = rb.linearVelocity;
        velocity.x = direction * speed;
        rb.linearVelocity = velocity;
    }
}
