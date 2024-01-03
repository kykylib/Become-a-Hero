using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnipeBullet : MonoBehaviour
{
    public GameObject hitEffect;
    public int damage = 120;
    float dll;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Enemy enemy = collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Boss boss = collider.GetComponent<Boss>();
        if (boss != null)
        {
            boss.TakeDamage(damage);
        }

        Quaternion collisionDir = transform.rotation;
        GameObject effect = Instantiate(hitEffect, transform.position, collisionDir);
        Destroy(effect, 0.25f);
        Destroy(gameObject);
    }

    public int getDamage()
    {
        return damage;
    }

    public void setDamage(int newDamage)
    {
        damage = newDamage;
    }

}
