using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class test : MonoBehaviour
{
    Mouse mouse;
    PlayerInput input;

    // Start is called before the first frame update
    void Start()
    {
        mouse = GetComponent<Mouse>();
        input = mouse.GetPlayerInput();

        input.Mouse.MousePress.performed  += Testoweee;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerInput.Mouse.MousePress.ReadValue<float>()); na przycisk
    }

    private void Testoweee(InputAction.CallbackContext context)
    {

        Debug.Log("hey");
        Ray testRay = new Ray(this.transform.position, Vector3.forward * 50);
        //Debug.DrawRay(this.transform.position,Vector3.forward);
        RaycastHit2D test = Physics2D.GetRayIntersection(testRay,10000f);
        if (test)
        {
            Debug.Log(test.collider.gameObject.tag);
        } 
    }
}
