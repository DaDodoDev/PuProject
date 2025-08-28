using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Transform player;

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (player.position-transform.position).normalized * (speed * Time.deltaTime);
        transform.position += (Vector3)direction;
    }
}
