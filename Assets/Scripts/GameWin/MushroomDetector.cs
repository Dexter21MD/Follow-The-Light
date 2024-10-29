using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomDetector : MonoBehaviour
{

    public static event Action onMushroomEnterWinZone;
    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.GetComponent<Mushroom>())
        {
            onMushroomEnterWinZone?.Invoke();
        }        
    }
}
