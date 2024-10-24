using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MushroomMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float stopDistance = 2f;

    public void Move(Vector3 destinationPos)
    {
        Vector3 moveDir = destinationPos - transform.position;
        moveDir = moveDir.normalized;
        if (!IsClose(destinationPos))
        {
            transform.Translate(moveDir * moveSpeed * Time.deltaTime);
        }
    }

    public bool IsClose(Vector3 destinationPos)
    {
        float distance = Vector3.Distance(destinationPos,this.transform.position);
        return distance <= stopDistance;
    }


}
