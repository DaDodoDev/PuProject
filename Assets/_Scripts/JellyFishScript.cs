using UnityEngine;

public class JellyFishScript : MonoBehaviour
{
    public Sprite[] animation;
    public float[] timePerFrame;
    public float[] speedPerFrame;
    public Rigidbody2D rb;
    public Transform player;

    public float time;
    public SpriteRenderer spriteRenderer;

    public float allTime;

    public float drag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        allTime = 0;
        for (int i = 0; i < timePerFrame.Length; i++)
        {
            allTime += timePerFrame[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        time %= allTime;

        
        
    }

    void FixedUpdate()
    {
        int whatFrame = 0;
        float timeNow = time;
        for (int i = 0; i < timePerFrame.Length; i++)
        {
            if (timeNow >= timePerFrame[i])
            {
                timeNow -= timePerFrame[i];
            }
            else
            {
                whatFrame = i;
                break;
            }
        }
        spriteRenderer.sprite = animation[whatFrame];
        rb.linearVelocity += (Vector2)(player.transform.position - transform.position).normalized * (speedPerFrame[whatFrame]);
        rb.linearVelocity *= drag;
    }
}
