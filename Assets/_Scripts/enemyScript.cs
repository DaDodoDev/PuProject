using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Transform player;

    public float speed;
    
    public Rigidbody2D rb;

    public Sprite up;
    public Sprite down;
    public Sprite left;
    public Sprite right;
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<playerMovementScript>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = (player.position-transform.position).normalized * speed ;

        if (Mathf.Abs(rb.linearVelocity.x) > Mathf.Abs(rb.linearVelocity.y))
        {
            if (rb.linearVelocityX < 0)
            {
                spriteRenderer.sprite = left;
            }
            else
            {
                spriteRenderer.sprite = right;
            }
        }
        else
        {
            if (rb.linearVelocityY < 0)
            {
                spriteRenderer.sprite = down;
            }
            else
            {
                spriteRenderer.sprite = up;
            }
        }

    }
}
