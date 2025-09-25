using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Transform player;

    public float speed;
    
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<playerMovementScript>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = (player.position-transform.position).normalized * speed ;

    }
}
