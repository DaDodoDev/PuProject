using UnityEngine;

public class bulletPrefab : MonoBehaviour
{
    public Vector2 direction;

    public float speed;
    public LayerMask wall;
    public GameObject particle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)direction * (speed * Time.deltaTime); 
        
        if(Physics2D.OverlapPoint(transform.position, wall)){Destroy(gameObject);}
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<enemyHealthScript>().TakeDamage(1);
            GameObject newPart = Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(newPart, 1f);
        }

        if (!collision.CompareTag("Player"))
        {
            Destroy(gameObject);    
        }
        
    }
}
