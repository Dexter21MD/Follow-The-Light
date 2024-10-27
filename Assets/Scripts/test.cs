using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerInput.Mouse.MousePress.ReadValue<float>()); na przycisk
        //Vector2 testowe = playerInput.Mouse.MousePosition.ReadValue<Vector2>(); 
        //Debug.Log(Camera.main.ScreenToWorldPoint(testowe)); NA POZYCJE
    }
}
