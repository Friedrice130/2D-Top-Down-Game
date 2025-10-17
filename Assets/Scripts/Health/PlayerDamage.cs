using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private Character.CharacterTypes damageType = Character.CharacterTypes.AI;
    [SerializeField] private int damageToApply = 1;
    
    private Health playerHealth;

    private void Start()
    {
        playerHealth = GetComponent<Health>();
}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet") && other.gameObject.layer != 13) //13 is PlayerProjectile layer
        {
            playerHealth.TakeDamage(damageToApply);
        }
    }
}

