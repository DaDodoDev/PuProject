using UnityEngine;

public class enemyControllerScript : MonoBehaviour
{
    public GameObject nextLevel;

    public GameObject upgrades;
    
    public bool spawnUpgrades = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnUpgrades = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0 && !spawnUpgrades)
        {
            nextLevel.SetActive(true);
            Destroy(gameObject);
        }
        if (transform.childCount == 0 && spawnUpgrades)
        {
            Transform upgrade = Instantiate(upgrades, transform.position, Quaternion.identity).transform;
            upgrade.SetParent(transform);
            spawnUpgrades = false;
        }
    }
}
