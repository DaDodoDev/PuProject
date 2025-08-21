using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    public float speed;
    public Vector2 axis;

    public Vector2 velocity;
    public float drag;
    
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        axis = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        transform.position += (Vector3)velocity * (speed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        velocity =  rb.linearVelocity;
        velocity += axis;
        if(drag < 0){drag = 0;}
        velocity /= drag +1;
    }
}
