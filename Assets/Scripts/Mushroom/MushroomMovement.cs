using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MushroomMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float stopDistance = 2f;

    public float directionX {get;set;}

    //To avoid big numbers in serializeFields affected by Time.FixedDeltaTime 
    const float VALUE_INSPECTOR_MULTIPLIER = 10.00f;
    Rigidbody2D rb;

    private void Awake() 
    {
        moveSpeed *= VALUE_INSPECTOR_MULTIPLIER;
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 destination)
    {
        Vector3 moveDir = destination - rb.position;
        moveDir = moveDir.normalized;
        directionX = Mathf.Sign(moveDir.x);
        rb.velocity = moveSpeed * Time.fixedDeltaTime * moveDir;
        
    }

    public void RestVelocity()
    {
        rb.velocity = new Vector2(0,0);
    }

    public bool IsClose(Vector3 destinationPos)
    {
        float distance = Vector3.Distance(destinationPos,rb.position);
        return distance <= stopDistance;
    }



}
