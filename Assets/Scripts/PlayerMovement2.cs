using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float moveSpeed = 20f;

    public Rigidbody2D rb;
    public Camera cam;
    public Animator animator;
    public Transform tr;

    Vector2 movement;
    Vector2 mousePos;
    Vector3 sides = new Vector3(2.0f, 0.0f, 0.0f);



    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        float animationDirHorizontal = 0, animationDirVertical = 0;

        if (angle < (90 - 22.5) && angle > (-90 +22.5)){
            animationDirHorizontal = 1f;
        }
        if ((angle > (90 + 22.5) && angle < (180)) || (angle > -180 && angle < (-90 - 22.5)))
        {
            animationDirHorizontal = -1f;
        }
        if (angle < (180 - 22.5) && angle > 22.5)
        {
            animationDirVertical = 1f;
        }
        if (angle < -22.5 && angle > (-180 + 22.5))
        {
            animationDirVertical = -1f;
        }

        animator.SetFloat("Horizontal", animationDirHorizontal);
        animator.SetFloat("Vertical", animationDirVertical);
        animator.SetFloat("Speed", movement.sqrMagnitude);


        if((animator.GetFloat("Horizontal") < 0 ) && tr.localScale.x > 0)
        {
            tr.localScale -= sides;
        }
        if ((animator.GetFloat("Horizontal") > 0) && tr.localScale.x < 0)
        {
            tr.localScale += sides;
        }
        
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void setSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    }

}
