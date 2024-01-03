using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bulletSound : MonoBehaviour
{
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        
    }
}
