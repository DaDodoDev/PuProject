using UnityEngine;

public class enemyHealthScript : MonoBehaviour
{
    public int health;


    public void TakeDamage(int damage)
    {
        
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
