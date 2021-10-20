using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{
    public int healAmount = 20;

    public override void OnPlayerEnter(Collider player)
    {
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();

        playerHealth.Heal(healAmount);
    }
}
