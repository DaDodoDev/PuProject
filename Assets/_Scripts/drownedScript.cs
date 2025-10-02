using UnityEngine;

public class drownedScript : MonoBehaviour
{
    public Transform player;

    public float speed;
    
    public Rigidbody2D rb;

    public GameObject bullet;
    public float shotCooldown;
    private float _shotCooldownNow;
    
    public float distanceToPlayer;
    public float runAwayDistance;
    
    public SpriteRenderer spriteRenderer;
    public Sprite[] upSprites;
    public Sprite[] downSprites;
    public Sprite[] leftSprites;
    public Sprite[] rightSprites;

    public float frame;
    public float framesPerSecond;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<playerMovementScript>().transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        frame += Time.deltaTime * framesPerSecond;
        if(frame >= downSprites.Length){frame = 0;}
        Vector2 direction = (player.position - transform.position).normalized;
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            if(direction.x > 0){spriteRenderer.sprite = rightSprites[(int)frame];}
            else{spriteRenderer.sprite = leftSprites[(int)frame];}
        }
        else
        {
            if(direction.y > 0){spriteRenderer.sprite = upSprites[(int)frame];}
            else{spriteRenderer.sprite = downSprites[(int)frame];}
        }
        if (Vector2.Distance(transform.position, player.position) > distanceToPlayer)
        {
            
            rb.linearVelocity = (player.position-transform.position).normalized * speed ;
            
        }
        else if (Vector2.Distance(transform.position, player.position) < runAwayDistance)
        {
            rb.linearVelocity = (transform.position-player.position).normalized * speed ;
            
        }
        else
        {
            rb.linearVelocity *= 0.65f;
            _shotCooldownNow += Time.deltaTime;
            if (_shotCooldownNow >= shotCooldown)
            {
                EvilBullet evilBullet = Instantiate(bullet, transform.position + new Vector3(0,0.5f,0), Quaternion.identity).GetComponent<EvilBullet>();
                
                evilBullet.direction  = (player.position - transform.position).normalized;
                _shotCooldownNow = 0;
            }
        }
    }
    
}
