using UnityEngine;

public class damageOverlay : MonoBehaviour
{

    public Color redColor;

    public float redColorTimer;
    public float timer;
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        spriteRenderer.color = Color.Lerp(Color.clear, redColor, timer/redColorTimer);
    }

    public void Damage()
    {
        timer = redColorTimer;
    }
}
