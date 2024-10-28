using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MushroomHealth : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] float takeDamageCooldownTimer = 1.00f;

    bool isImmortal = false;
    // Start is called before the first frame update

    public static event Action onMushroomDeath;

    public void DecreaseHealth(float damage)
    {
        if (!isImmortal)
        {
        health -= damage;
        CheckIfDied();
        isImmortal = true;
        StartCoroutine(DamageCooldown());
        }

    }
    private void CheckIfDied()
    {
        if (health <= 0)
        {
            this.enabled = false;
            onMushroomDeath?.Invoke();
        }
    }


    private IEnumerator DamageCooldown()
    {
        yield return new WaitForSeconds(takeDamageCooldownTimer);
        isImmortal = false;
    }
}
