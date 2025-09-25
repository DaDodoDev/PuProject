using UnityEngine;

public class EvilBullet : MonoBehaviour
{
    public Vector2 direction;

    public float speed;
    public LayerMask wall;


    void Update()
    {
        transform.position += (Vector3)direction * (speed * Time.deltaTime); 
        
        if(Physics2D.OverlapPoint(transform.position, wall)){Destroy(gameObject);}
    }
}
