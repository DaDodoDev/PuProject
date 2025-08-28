using UnityEngine;

public class playerShootScript : MonoBehaviour
{
    public Vector2 direction;

    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector2.zero;
        if(Input.GetKey(up)){direction += Vector2.up;}
        if(Input.GetKey(down)){direction += Vector2.down;}
        if(Input.GetKey(left)){direction += Vector2.left;}
        if(Input.GetKey(right)){direction += Vector2.right;}
    }
}
