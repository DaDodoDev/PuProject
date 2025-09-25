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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<playerMovementScript>().transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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
