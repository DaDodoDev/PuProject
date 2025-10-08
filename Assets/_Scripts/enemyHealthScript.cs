using UnityEngine;

public class enemyHealthScript : MonoBehaviour
{
    public int health;
    public bool boss;
    public screenOverlay overlay;
    public playerHealthScript playerHealthScript;
    public void TakeDamage(int damage)
    {
        
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            if (boss)
            {
                overlay.turnSolid = true;
                playerHealthScript.GetComponent<Collider2D>().enabled = false;
            }
        }
    }
}
