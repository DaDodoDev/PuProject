using UnityEngine;

public class enemyHealthScript : MonoBehaviour
{
    public int health;
    public GameObject damageEffect;

    public void TakeDamage(int damage)
    {
        GameObject newPart = Instantiate(damageEffect, transform.position, Quaternion.identity);
        Destroy(newPart, 1f);
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
