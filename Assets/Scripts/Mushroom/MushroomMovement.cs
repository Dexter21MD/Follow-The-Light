using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MushroomMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float stopDistance = 2f;
    [SerializeField] GameObject laternToFollow;
    // Start is called before the first frame update



    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 moveDir = laternToFollow.transform.position - transform.position;
        moveDir = moveDir.normalized;
        if (!IsClose())
        {
            transform.Translate(moveDir * moveSpeed * Time.deltaTime);
        }
    }

    private bool IsClose()
    {
        float distance = Vector2.Distance(laternToFollow.transform.position,this.transform.position);
        return distance <= stopDistance;
    }


}
