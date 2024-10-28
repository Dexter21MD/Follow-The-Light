using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    // Start is called before the first frame update
    public MushroomMovement mushroomMovement {get;set;}

    MushroomHealth mushroomHealth;
    public static event Action<MushroomHealth> onMushroomDanger;
    void Awake()
    {
        mushroomHealth = GetComponent<MushroomHealth>();
        mushroomMovement = GetComponent<MushroomMovement>();
    }

    private void Update() 
    {
        CalloutIfDanger();
    }

    private void CalloutIfDanger()
    {
        if (mushroomMovement.GetInDangerStatus())
        {
            onMushroomDanger?.Invoke(mushroomHealth);
        }
    }
    

}
