using UnityEngine;

public class BossShoot : MonoBehaviour
{
    public GameObject bullet;

    public float time;

    public float timeBeforeShoot;

    public float timeAfterShoot;
    public int numberOfBullets;

    public bool canShoot;
    public bossStateMachine bossStateMachine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        canShoot = true;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > timeBeforeShoot && canShoot)
        {
            canShoot = false;
            float direction = 0;
            for (int i = 0; i < numberOfBullets; i++)
            {
                direction += 360f/numberOfBullets;
                Vector2 bulletDirection = new Vector2(Mathf.Cos(direction * Mathf.Deg2Rad), Mathf.Sin(direction * Mathf.Deg2Rad));
                GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
                newBullet.GetComponent<EvilBullet>().direction = bulletDirection;
            }
        }

        if (time > timeAfterShoot)
        {
            bossStateMachine.timeAlive = bossStateMachine.timeAliveBeforeAttack - 0.1f;
            GetComponent<BossShoot>().enabled = false;
        }
    }
}
