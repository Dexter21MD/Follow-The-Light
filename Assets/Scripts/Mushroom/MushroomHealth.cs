using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomHealth : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] float takeDamageCooldownTimer = 1.00f;

    bool isImmortal = false;
    // Start is called before the first frame update



    public void DecreaseHealth(float damage)
    {
        if (!isImmortal)
        {
        health -= damage;
        isImmortal = true;
        StartCoroutine(DamageCooldown());
        }

    }


    private IEnumerator DamageCooldown()
    {
        yield return new WaitForSeconds(takeDamageCooldownTimer);
        isImmortal = false;
    }
}
