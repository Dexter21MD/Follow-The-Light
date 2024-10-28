using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<MonoBehaviour> listOfBehavioursToDisableOnDeath;
    public MushroomMovement mushroomMovement {get;set;}

    MushroomHealth mushroomHealth;
    public static event Action<MushroomHealth> onMushroomDanger;
    void Awake()
    {
        mushroomHealth = GetComponent<MushroomHealth>();
        mushroomMovement = GetComponent<MushroomMovement>();
    }

    private void OnEnable() 
    {
        MushroomHealth.onMushroomDeath += DisableScriptOnDeath;
        
    }
    private void OnDisable() 
    {
        MushroomHealth.onMushroomDeath -= DisableScriptOnDeath;
        
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

    private void DisableScriptOnDeath()
    {
        foreach (MonoBehaviour component in listOfBehavioursToDisableOnDeath)
        {
           component.enabled = false;
        }
    }
    

}
