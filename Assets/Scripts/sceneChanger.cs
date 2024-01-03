using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class sceneChanger : MonoBehaviour
{
    void Start()
    {
        GetComponent<AudioSource>().Play();
        StartCoroutine(ExampleCoroutine());
    }
    private IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(57);
        SceneManager.LoadScene("Gameplay");
    }
            
    
}
