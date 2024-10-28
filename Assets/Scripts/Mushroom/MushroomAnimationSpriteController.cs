using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    private void OnEnable() 
    {
        MushroomHealth.onMushroomDeath += SetDeathAnimation;
        
    }
    private void OnDisable() 
    {
        MushroomHealth.onMushroomDeath -= SetDeathAnimation;
        
    }    

    // Update is called once per frame
    void Update()
    {
        ControlMovementAnimation(mushroom.mushroomMovement.GetRestStatus(),mushroom.mushroomMovement.GetMoveStatus());
        FlipSprite(mushroom.mushroomMovement.GetDirectionX());
    }


    private void ControlMovementAnimation(bool isResting, bool isMoving)
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

    private void SetDeathAnimation()
    {
        animator.SetTrigger("Died");
        this.enabled = false;
    }
}
