using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectDetection : MonoBehaviour
{

    Mouse mouse;
    PlayerInput input;

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
        if (hit)
        {
            Debug.Log(hit.collider.gameObject.name);
        }         
    }
}
