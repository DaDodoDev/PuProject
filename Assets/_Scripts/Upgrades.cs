using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public bool healHealth;
    public string[] upgrades;
    public float[] upgradeValue;
    public Transform player;


    public int whatUpgrade;
    public Sprite[] upgradesSprite;
    public Sprite healSprite;
    
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        whatUpgrade = Random.Range(0, upgrades.Length);
        
        player = GameObject.FindGameObjectWithTag("Player").transform;
        if(healHealth){GetComponent<SpriteRenderer>().sprite = healSprite;}else{GetComponent<SpriteRenderer>().sprite = upgradesSprite[whatUpgrade];}
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
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
                    else if (whatUpgrade == 4)
                    {
                        player.GetComponent<playerStats>().shotGunLevel += (int)upgradeValue[whatUpgrade];
                        player.GetComponent<playerStats>().shootCooldown *= 1.5f;
                    }
                    else if (whatUpgrade == 5)
                    {
                        player.GetComponent<playerStats>().sizeLevel += upgradeValue[whatUpgrade];
                        float size = player.GetComponent<playerStats>().sizeLevel;
                        player.transform.localScale =   new Vector3(size, size, size);
                        player.GetComponent<playerStats>().maxHealth += (int)upgradeValue[0];
                        player.GetComponent<playerHealthScript>().health += (int)upgradeValue[0];
                        player.GetComponent<playerStats>().maxHealth += (int)upgradeValue[0];
                        player.GetComponent<playerHealthScript>().health += (int)upgradeValue[0];
                    }
                }
    
                
                Destroy(transform.parent.gameObject);
            }
        }
        else
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        
    }
}
