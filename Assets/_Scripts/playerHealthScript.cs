using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerHealthScript : MonoBehaviour
{
    public SpriteRenderer[] playerHealth;

    public int health;

    public Sprite healthSprite;

    public Sprite deadHealthSprite;
    public float invisibilityTime;
    private float invisibilityTimeNow;
    public playerStats playerStats;
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
            playerHealth[i].color = Color.white;
            if (health > i)
            {
                playerHealth[i].sprite = healthSprite;
            }else if (playerStats.maxHealth > i)
            {
                playerHealth[i].sprite = deadHealthSprite;
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
            if(health <= 0){StartCoroutine(Die());}
        }

    }

    IEnumerator Die()
    {
        Destroy(GetComponent<Rigidbody2D>());
        playerStats.playerSpeed = 0;
        yield return new WaitForSeconds(invisibilityTime);
        SceneManager.LoadScene(sceneName: SceneManager.GetActiveScene().name);
        
    }
}
