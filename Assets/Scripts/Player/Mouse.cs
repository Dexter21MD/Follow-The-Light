using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private PlayerInput playerInput;
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
    }
    private void OnEnable() 
    {
        playerInput.Enable();    
    }

    private void OnDisable() 
    {
        playerInput.Disable();    
    }        


    public PlayerInput GetPlayerInput()
    {
        return playerInput;
    }
}
