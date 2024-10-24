using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject laternToFollow;

    MushroomMovement mushroomMovement;
    void Awake()
    {
        mushroomMovement = GetComponent<MushroomMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!mushroomMovement.IsClose(laternToFollow.transform.position))
        {
            mushroomMovement.Move(laternToFollow.transform.position);    
        }
        
    }
}
