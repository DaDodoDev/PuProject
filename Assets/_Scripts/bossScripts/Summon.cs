using System;
using UnityEngine;

public class Summon : MonoBehaviour
{
    public GameObject guardians;
    public float timeBeforeSummon;

    public float waitTime;

    public float time;

    public float offset;

    public bool canSummon;
    public bossStateMachine bossStateMachine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        time = 0;
        canSummon= true;
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time >= timeBeforeSummon&& canSummon)
        {
            Instantiate(guardians, transform.position+ new Vector3(0, offset,0 ), Quaternion.identity);
            Instantiate(guardians, transform.position+ new Vector3(0, -offset,0 ), Quaternion.identity);
            Instantiate(guardians, transform.position+ new Vector3(offset,0,0 ), Quaternion.identity);
            Instantiate(guardians, transform.position+ new Vector3(-offset,0,0 ), Quaternion.identity);
            canSummon = false;
        }

        if (time >= waitTime)
        {
            bossStateMachine.timeAlive = bossStateMachine.timeAliveBeforeAttack - 0.1f;
            GetComponent<Summon>().enabled = false;
        }
    }
}
