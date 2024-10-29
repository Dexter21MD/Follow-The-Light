using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealthUI : MonoBehaviour
{
    [SerializeField] TMP_Text healthText;
    // Start is called before the first frame update

    private void OnEnable() 
    {
        MushroomHealth.onMushroomDamage += UpdateHealthText;
    }
    private void OnDisable() 
    {
        MushroomHealth.onMushroomDamage -= UpdateHealthText;
    }

    private void UpdateHealthText(float health)
    {
        healthText.text = health.ToString();
    }

    

}
