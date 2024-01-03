using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bullet_2 : MonoBehaviour
{
    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    { 
        GameObject effect = Instantiate(hitEffect, transform.position, transform.rotation);
        Destroy(effect, 0.05f);



        Destroy(gameObject);
    }


}
