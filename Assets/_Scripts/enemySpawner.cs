using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public float cooldown;

    public float cooldownGoDownPercentEveryFiveSeconds;

    public float timeBeforeCooldownGoDown;

    public float coolDownNow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coolDownNow -= Time.deltaTime;
        if(coolDownNow <= 0){Instantiate(enemy, new Vector3(Random.Range(-1f,1f), Random.Range(-1f,1f), 0).normalized*15f, Quaternion.identity);
            coolDownNow = cooldown;
        }
        
        timeBeforeCooldownGoDown -= Time.deltaTime;
        if (timeBeforeCooldownGoDown <= 0)
        {
            cooldown *= cooldownGoDownPercentEveryFiveSeconds;
            timeBeforeCooldownGoDown = 5;
        }
    }
}
