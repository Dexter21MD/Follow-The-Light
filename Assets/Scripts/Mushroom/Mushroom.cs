using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject laternToFollow;
    [SerializeField] float powerUpLevel = 0.00f;
    [SerializeField] float powerLevelSpeed = 0.5f; // for prototype, move it to scriptobject later
    MushroomMovement mushroomMovement;
    SpriteRenderer spriteRenderer;
    Animator animator;

    bool isMoving;

    void Awake()
    {
        mushroomMovement = GetComponent<MushroomMovement>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Update() 
    {
        isMoving = !mushroomMovement.IsClose(laternToFollow.transform.position);

        //TODO move it to different script
        FlipSprite();
        animator.SetBool("Moving",isMoving);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (isMoving)
        {
            mushroomMovement.Move(laternToFollow.transform.position);    
        }
        else
        {
            mushroomMovement.RestVelocity();
            Rest();
        }
        

    }

    private void FlipSprite()
    {
        spriteRenderer.flipX = (mushroomMovement.directionX == 1) ? true : false;
    }

    private void Rest()
    {
        powerUpLevel += powerLevelSpeed * Time.deltaTime;
        //More later
    }
}