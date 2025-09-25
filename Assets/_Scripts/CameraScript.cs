using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;

    public Vector2 clampArea;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -10);
        if(transform.position.x > clampArea.x){transform.position = new Vector3(clampArea.x, transform.position.y, transform.position.z);}
        else if (transform.position.x < -clampArea.x){transform.position = new Vector3(-clampArea.x, transform.position.y, transform.position.z);}
        
        if(transform.position.y > clampArea.y){transform.position = new Vector3(transform.position.x, clampArea.y, transform.position.z);}
        else if (transform.position.y < -clampArea.y){transform.position = new Vector3(transform.position.x, -clampArea.y, transform.position.z);}
    }
}
