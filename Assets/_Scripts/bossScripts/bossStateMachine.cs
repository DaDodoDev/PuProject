using UnityEngine;

public class bossStateMachine : MonoBehaviour
{

    public Summon summonScript;
    public Dash dashScript;
    public BossShoot shootScript;

    public float timeAlive;

    public float timeAliveBeforeAttack;

    public SpriteRenderer spriteRenderer;
    public Sprite summonSprite;
    public Sprite dashSprite;
    public Sprite shootSprite;

    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (rb.linearVelocityX > 0)
        {
            spriteRenderer.flipX = true;
        }else if (rb.linearVelocityX < 0)
        {
            spriteRenderer.flipX = false;
        }
        timeAlive += Time.deltaTime;
        if (timeAlive > timeAliveBeforeAttack)
        {
            timeAlive = -100000;
            NewAttack();
        }
    }

    // Update is called once per frame
    public void NewAttack()
    {
        int attack = Random.Range(1, 4);

        if (attack==1)
        {
            summonScript.enabled = true;
            spriteRenderer.sprite = summonSprite;
        }
        else if (attack == 2)
        {
            dashScript.enabled = true;
            spriteRenderer.sprite = dashSprite;
        }
        else if (attack == 3)
        {
            shootScript.enabled = true;
            spriteRenderer.sprite = shootSprite;
        }
        
    }
}
