using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public bool healHealth;
    public string[] upgrades;
    public float[] upgradeValue;
    public Transform player;


    public int whatUpgrade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        whatUpgrade = Random.Range(0, upgrades.Length);
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < 1f)
        {
            if (healHealth)
            {
                player.GetComponent<playerHealthScript>().health = player.GetComponent<playerStats>().maxHealth;
            }
            else
            {
                if (whatUpgrade == 0)
                {
                    player.GetComponent<playerStats>().maxHealth += (int)upgradeValue[whatUpgrade];
                    player.GetComponent<playerHealthScript>().health += (int)upgradeValue[whatUpgrade];
                }
                else if (whatUpgrade == 1)
                {
                    player.GetComponent<playerStats>().bulletSpeed += upgradeValue[whatUpgrade];
                }else if (whatUpgrade == 2)
                {
                    player.GetComponent<playerStats>().shootCooldown *= upgradeValue[whatUpgrade];
                }    else if (whatUpgrade == 3)
                {
                    player.GetComponent<playerStats>().playerSpeed += upgradeValue[whatUpgrade];
                }        
            }

            
            Destroy(transform.parent.gameObject);
        }
    }
}
