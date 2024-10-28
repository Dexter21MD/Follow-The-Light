using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] float damage = 10f;
    // Start is called before the first frame update
    
    private void OnEnable() 
    {
        Mushroom.onMushroomDanger += DealDamage;
    }
    private void OnDisable() 
    {
        Mushroom.onMushroomDanger -= DealDamage;
    }

    private void DealDamage(MushroomHealth mushroomHealth)
    {
        mushroomHealth.DecreaseHealth(damage);
    }




}
