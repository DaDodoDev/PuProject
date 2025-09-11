using UnityEngine;

public class playerHealthScript : MonoBehaviour
{
    public SpriteRenderer[] playerHealth;

    public int health;
    public int maxHealth;

    public Color healthColor;

    public Color deadHealthColor;
    public float invisibilityTime;
    private float invisibilityTimeNow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        invisibilityTimeNow -= Time.deltaTime;
        for (int i = 0; i < playerHealth.Length; i++)
        {
            if (health > i)
            {
                playerHealth[i].color = healthColor;
            }else if (maxHealth > i)
            {
                playerHealth[i].color = deadHealthColor;
            }
            else
            {
                playerHealth[i].color = Color.clear;
            }
        }
    }

    public void TakeDamage()
    {
        if (invisibilityTimeNow < 0)
        {
            health--;
            invisibilityTimeNow = invisibilityTime;
            if(health <= 0){Destroy(gameObject);}
        }

    }
}
