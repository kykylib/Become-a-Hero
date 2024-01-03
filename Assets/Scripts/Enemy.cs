using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int  maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public Transform Hero;
    public  Transform SelfTr;
    public float moveSpeed = 5f;
    public Animator animator;



    private Rigidbody2D rb;
    private Vector2 movement;
    Vector3 sides = new Vector3(3f, 0.0f, 0.0f);




    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        Vector3 direction = Hero.position - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if((angle > 90 || angle < -90) && SelfTr.localScale.x > 0)
        {
            SelfTr.localScale -= sides;
        }
        if ((angle < 90 && angle > -90) && SelfTr.localScale.x < 0)
        {
            SelfTr.localScale += sides;
        }


        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);
        if( currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<AudioSource>().Play();
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Drill")
        {
            Attack();        
        }
        
        if(collider.tag == "explosion")
        {
            TakeDamage(30);
        }
    }

    private void Attack()
    {
        animator.SetBool("Attacking", true);
    }

}