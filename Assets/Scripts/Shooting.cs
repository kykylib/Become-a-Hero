using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Player;
    public Transform muzzle;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject bulletSnipe;
    public GameObject bulletHeavy;
    public Animator animator;
    public int shooterCounter; 

    public float bulletForce = 30f;
    public float FireRate = 2f;         
    private float lastfired = 0f ;     

 
    Vector3 doubleShotOffset = new Vector3(0, 0, 0);
    Vector3 mainShotOffset = new Vector3(0, 0, 0);
    public float bulletDistance = 0.5f;


    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("Shooting", true);
            if ((Time.time - lastfired) > (1 / FireRate))
            {
                lastfired = Time.time;
                Shoot(); 
            }
        } else
        {
            animator.SetBool("Shooting", false);
        }
    }

    void Shoot()
    {

        float horizon = animator.GetFloat("Horizontal");
        float vert = animator.GetFloat("Vertical");
        float ratio = (1 / Mathf.Sqrt(2));
        mainShotOffset = new Vector3(ratio * vert, ratio * horizon, 0);
        if (horizon == 1)
        {
            doubleShotOffset = new Vector3(-vert * bulletDistance, horizon * bulletDistance, 0f);
        } else
        {
            doubleShotOffset = new Vector3(vert * bulletDistance, -horizon * bulletDistance, 0f);
        }
        
        if(shooterCounter == 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            
            Vector3 direction = new Vector3(horizon, vert, 0f);

            rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
        }

        if(shooterCounter == 1)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position + doubleShotOffset, Quaternion.identity);
            GameObject bullet1 = Instantiate(bulletPrefab, firePoint.position - doubleShotOffset, Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();

            Vector3 direction = new Vector3(horizon, vert, 0f);

            rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
            rb1.AddForce(direction * bulletForce, ForceMode2D.Impulse);
        }

        if (shooterCounter == 2)
        {
            
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position + (2 * doubleShotOffset), Quaternion.identity);
            GameObject bullet1 = Instantiate(bulletPrefab, firePoint.position - (2 * doubleShotOffset), Quaternion.identity);
            GameObject bullet2 = Instantiate(bulletPrefab, firePoint.position , Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();

            Vector3 direction = new Vector3(horizon, vert, 0f);

            rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
            rb1.AddForce(direction * bulletForce, ForceMode2D.Impulse);
            rb2.AddForce(direction * bulletForce, ForceMode2D.Impulse);
        }

        if (shooterCounter == 3)
        {
            GameObject heavy = Instantiate(bulletHeavy, firePoint.position, Quaternion.identity);
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = heavy.GetComponent<Rigidbody2D>();
            Rigidbody2D rb1 = bullet.GetComponent<Rigidbody2D>();

            Vector3 direction = new Vector3(horizon, vert, 0f);

            rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
            rb1.AddForce(-1 * direction * bulletForce, ForceMode2D.Impulse);
        }

        if (shooterCounter == 4)
        {

            GameObject heavy = Instantiate(bulletHeavy, firePoint.position + doubleShotOffset, Quaternion.identity);
            GameObject heavy1 = Instantiate(bulletHeavy, firePoint.position - doubleShotOffset, Quaternion.identity);
            GameObject heavy2 = Instantiate(bulletHeavy, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = heavy.GetComponent<Rigidbody2D>();
            Rigidbody2D rb1 = heavy1.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = heavy2.GetComponent<Rigidbody2D>();

            Vector3 direction = new Vector3(horizon, vert, 0f);
            Vector3 right = new Vector3(vert, -1 * horizon, 0f);
            Vector3 left = new Vector3(-1 * vert,  horizon, 0f);

            rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
            rb1.AddForce(right * bulletForce, ForceMode2D.Impulse);
            rb2.AddForce(left * bulletForce, ForceMode2D.Impulse);
        }

        if (shooterCounter == 5)
        {
            GameObject snipe = Instantiate(bulletSnipe, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = snipe.GetComponent<Rigidbody2D>();
           
            Vector3 direction = new Vector3(horizon, vert, 0f);

            rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);
        }

    }

    public void setFireRate(float newRate)
    {
        FireRate = newRate;
    }

    public void setBulletForce(float newBF)
    {
        bulletForce = newBF;
    }

    public void setShooterCounter(int newSC)
    {
        shooterCounter = newSC;
    }
}
