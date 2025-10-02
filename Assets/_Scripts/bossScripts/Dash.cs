using UnityEngine;

public class Dash : MonoBehaviour
{
    public Transform player;

    public float speed;
    public Rigidbody2D rb;

    public float time;

    public float timeBeforeReset;
    public bossStateMachine bossStateMachine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        time = 0;
        rb.linearVelocity = (player.position - transform.position).normalized * speed;
        rb.linearDamping = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeBeforeReset)
        {
            rb.linearDamping = 1;
            bossStateMachine.timeAlive = bossStateMachine.timeAliveBeforeAttack - 0.1f;
            GetComponent<Dash>().enabled = false;
        }
    }
}
