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

    public static event Action<float> onMushroomDamage;
    public static event Action onMushroomDeath;

    private void Start() 
    {
        onMushroomDamage?.Invoke(health);
    }
    public void DecreaseHealth(float damage)
    {
        if (!isImmortal)
        {
        health -= damage;
        onMushroomDamage?.Invoke(health);
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
