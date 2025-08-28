using UnityEngine;

public class playerShootScript : MonoBehaviour
{
    
    public playerStats playerStats;
    public Vector2 shootDirection;

    public KeyCode upKey;
    
    public KeyCode downKey;
    
    public KeyCode leftKey;
    
    public KeyCode rightKey;

    public KeyCode directionKey;

    public GameObject bullet;

    public float shootCoolDown;

    public float shootCoolDownNow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
        if(Input.GetKeyDown(upKey)){directionKey = upKey; shootDirection = Vector2.up;}
        if(Input.GetKeyDown(downKey)){directionKey = downKey; shootDirection = Vector2.down;}
        if(Input.GetKeyDown(leftKey)){directionKey = leftKey; shootDirection = Vector2.left;}
        if(Input.GetKeyDown(rightKey)){directionKey = rightKey; shootDirection = Vector2.right;}

        if (Input.GetKeyUp(directionKey))
        {
            directionKey = KeyCode.None;
        }

        shootCoolDownNow += Time.deltaTime;
        shootCoolDown = playerStats.shootCooldown;
        if (shootCoolDownNow > shootCoolDown)
        {
            if (directionKey != KeyCode.None)
            {
                GameObject newBullet = Instantiate(bullet, transform.position + (Vector3)shootDirection*0.5f, Quaternion.identity);
                newBullet.GetComponent<bulletPrefab>().direction = shootDirection;
                shootCoolDownNow -= shootCoolDown;
            }
            else
            {
                shootCoolDownNow = shootCoolDown;
            }
        }
    }
}
