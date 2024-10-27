using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseInteraction : MonoBehaviour
{

    Mouse mouse;
    PlayerInput input;

    bool isHoldingObject = false;

    [SerializeField] LayerMask layerToInteract;
    const float RAY_LEN = 50.00f;
    const float RAY_DISTANCE = 100.00f;
    // Start is called before the first frame update
    void Start()
    {
        mouse = GetComponent<Mouse>();
        input = mouse.GetPlayerInput();
        input.Mouse.MousePress.performed += Detection;        
    }


    private void OnDisable() 
    {
        input.Mouse.MousePress.performed -= Detection;
    }



    private void Detection(InputAction.CallbackContext context)
    {
        Ray ray = new Ray(this.transform.position, Vector3.forward * RAY_LEN);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray,RAY_DISTANCE,layerToInteract);
        // Thanks to layer further checks (if gameobject have class Object) are not needed
        if (hit)
        {
            SetObjectParentToMouse(hit.collider.GetComponent<Object>());
        }         
    }


    private void SetObjectParentToMouse(Object objectToChange)
    {
        if(objectToChange.GetIsMovable() && !isHoldingObject)
        {
            objectToChange.transform.SetParent(this.transform,true);
        }
        else
        {
            objectToChange.transform.SetParent(null);
        }

        isHoldingObject = !isHoldingObject;
    }
}
