using UnityEngine;

public class bulletPrefab : MonoBehaviour
{
    public Vector2 direction;

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)direction * (speed * Time.deltaTime); 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print("kabooooom");
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<enemyHealthScript>().TakeDamage(1);
        }

        if (!collision.CompareTag("Player"))
        {
            Destroy(gameObject);    
        }
        
    }
}
