using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Transform player;

    public float speed;
    public float drag;
    public Rigidbody2D rb;

    public Sprite up;
    public Sprite down;
    public Sprite left;
    public Sprite right;
    public SpriteRenderer spriteRenderer;

    
    public float timeBeforeMaxSpeed;
    public float timeBeforeMaxSpeedNow;
    
    public bool anim;

    public Sprite[] ups;
    public Sprite[] downs;
    public Sprite[] lefts;
    public Sprite[] rights;

    public float frame;

    public float framePerSecond;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<playerMovementScript>().transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        timeBeforeMaxSpeedNow  += Time.fixedDeltaTime;
        rb.linearVelocity += (Vector2)(player.position-transform.position).normalized* Mathf.Lerp(0, speed, Mathf.Clamp01(timeBeforeMaxSpeedNow/timeBeforeMaxSpeed)); ;
        rb.linearVelocity *= drag;

        if (anim)
        {
            frame += Time.fixedDeltaTime *  framePerSecond;
            frame %= 2;
            if (Mathf.Abs(rb.linearVelocity.x) > Mathf.Abs(rb.linearVelocity.y))
            {
                if (rb.linearVelocityX < 0)
                {
                    
                    spriteRenderer.sprite = lefts[(int)frame];
                }
                else
                {
                    spriteRenderer.sprite = rights[(int)frame];
                }
            }
            else
            {
                if (rb.linearVelocityY < 0)
                {
                    spriteRenderer.sprite = downs[(int)frame];
                }
                else
                {
                    spriteRenderer.sprite = ups[(int)frame];
                }
            }
        }
        else
        {
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
}
