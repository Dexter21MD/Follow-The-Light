using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowGameStatusText : MonoBehaviour
{

    [SerializeField] TMP_Text winText;

    [SerializeField] TMP_Text loseText;

    private void Awake() 
    {
        winText.enabled = false;
        loseText.enabled = false;   
    }


    private void ShowWinText()
    {
        winText.enabled = true;
    }
    private void ShowLoseText()
    {
        loseText.enabled = true;
    }    

    private void OnEnable() 
    {
        MushroomHealth.onMushroomDeath += ShowLoseText;
    }
    private void OnDisable() 
    {
        MushroomHealth.onMushroomDeath -= ShowLoseText;
    }


}
