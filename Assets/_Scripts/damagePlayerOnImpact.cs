using System;
using UnityEngine;

public class damagePlayerOnImpact : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.GetComponent<playerHealthScript>().TakeDamage();
        }
    }
}
