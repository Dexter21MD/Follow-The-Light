using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomAnimationSpriteController : MonoBehaviour
{
    // Start is called before the first frame update

    Mushroom mushroom;
    SpriteRenderer spriteRenderer;
    Animator animator;    

    void Awake()
    {
        mushroom = GetComponent<Mushroom>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ControlAnimation(mushroom.mushroomMovement.GetRestStatus(),mushroom.mushroomMovement.GetMoveStatus());
        FlipSprite(mushroom.mushroomMovement.GetDirectionX());
    }


    private void ControlAnimation(bool isResting, bool isMoving)
    {
        if (isResting)
        {
            animator.SetBool("Moving",!isResting);
            
        }
        else if (isMoving)
        {
            animator.SetBool("Moving",isMoving);    
        }
        else
        {
            animator.SetBool("Moving",isMoving); 
        }
    }

    private void FlipSprite(float direction)
    {
        spriteRenderer.flipX = direction == 1;
    }
}
