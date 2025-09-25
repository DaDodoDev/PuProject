using UnityEngine;

public class BackgroundWaterScript : MonoBehaviour
{
    public Vector2 waterVelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)waterVelocity * Time.deltaTime;
        if (transform.position.y < -3)
        {
            transform.position += new Vector3(0, 3, 0);
        }
        
        if (transform.position.x > 3)
        {
            transform.position += new Vector3(-3, 0, 0);
        }

    }
}
