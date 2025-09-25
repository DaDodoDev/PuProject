using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public string[] upgrades;
    public float[] upgradeValue;
    public Transform player;

    public GameObject partner;

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
        if (Vector2.Distance(transform.position, player.position) < 0.3f)
        {
            if (whatUpgrade == 0)
            {
                player.GetComponent<playerStats>().maxHealth += (int)upgradeValue[whatUpgrade];
            }
            
            Destroy(partner);
            Destroy(gameObject);
        }
    }
}
