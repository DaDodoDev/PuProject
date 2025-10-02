using UnityEngine;

public class bossStateMachine : MonoBehaviour
{

    public Summon summonScript;
    public Dash dashScript;
    public BossShoot shootScript;

    public float timeAlive;

    public float timeAliveBeforeAttack;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
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
        }
        else if (attack == 2)
        {
            dashScript.enabled = true;
        }
        else if (attack == 3)
        {
            shootScript.enabled = true;
        }
        
    }
}
