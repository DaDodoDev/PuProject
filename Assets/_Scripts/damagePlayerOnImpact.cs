using System;
using UnityEngine;

public class damagePlayerOnImpact : MonoBehaviour
{
    public bool destroyOnImpact;
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.GetComponent<playerHealthScript>().TakeDamage();
            if (destroyOnImpact)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.GetComponent<playerHealthScript>().TakeDamage();
            if (destroyOnImpact)
            {
                Destroy(gameObject);
            }
        }
    }
}
