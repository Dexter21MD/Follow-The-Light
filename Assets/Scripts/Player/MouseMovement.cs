using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    Mouse mouse;
    PlayerInput input;


    const int MOUSE_Z_DISTANCE = -4;
    // Start is called before the first frame update
    void Awake()
    {
        mouse = GetComponent<Mouse>();
        input = mouse.GetPlayerInput();
    }

    // Update is called once per frame
    void Update()
    {
        SetGameObjectToMousePos();
    }


    private Vector2 ConvertMouseCordsToGameCords()
    {
        Vector2 mousePos = input.Mouse.MousePosition.ReadValue<Vector2>();
        Vector2 gameWorldPos = Camera.main.ScreenToWorldPoint(mousePos);
        return gameWorldPos;
    }

    private void SetGameObjectToMousePos()
    {
        Vector2 convertedVector = ConvertMouseCordsToGameCords();
        this.transform.position = new Vector3(convertedVector.x,convertedVector.y,MOUSE_Z_DISTANCE);
    }
}
