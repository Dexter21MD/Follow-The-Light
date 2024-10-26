using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    // Start is called before the first frame update

    public MushroomMovement mushroomMovement {get;set;}


    void Awake()
    {
        mushroomMovement = GetComponent<MushroomMovement>();
    }



}
