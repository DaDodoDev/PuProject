using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    public Vector2Int axis; 
    public SpriteRenderer spriteRenderer;
    public Sprite[] upSprites;
    public Sprite[] downSprites;
    public Sprite[] leftSprites;
    public Sprite[] rightSprites;

    public float frame;
    public float framesPerSecond;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        axis = new Vector2Int((int)Input.GetAxisRaw("Horizontal"), (int)Input.GetAxisRaw("Vertical"));

        if (axis.x == 1)
        {
            frame += Time.deltaTime*framesPerSecond;
            if (frame >= rightSprites.Length)
            {
                frame = 0;
            }

            spriteRenderer.sprite = rightSprites[(int)frame];
        }
        else if (axis.x == -1)
        {
            frame += Time.deltaTime*framesPerSecond;
            if (frame >= leftSprites.Length)
            {
                frame = 0;
            }

            spriteRenderer.sprite = leftSprites[(int)frame];
        }
        else if (axis.y == 1)
        {
            frame += Time.deltaTime*framesPerSecond;
            if (frame >= upSprites.Length)
            {
                frame = 0;
            }

            spriteRenderer.sprite = upSprites[(int)frame];
        }
        else if (axis.y == -1)
        {
            frame += Time.deltaTime*framesPerSecond;
            if (frame >= downSprites.Length)
            {
                frame = 0;
            }

            spriteRenderer.sprite = downSprites[(int)frame];
        }
        
    }
}
