using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState {  SPAWNING, WAITING, COUNTING };
    public GameObject player;
    public GameObject thisobject;
    public GameObject canvasManager;

    [System.Serializable]
    public class Wave
    {
        public string Name;
        public Transform enemy1;
        public Transform enemy2;
        public Transform enemy3;
        public Transform enemy4;
        public int countEnemy1;
        public int countEnemy2;
        public int countEnemy3;
        public int countEnemy4;

        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints;

    public float timeBetweenWaves = 5f;
    private float waveCountdown;

    private float searchCountdown = 1f;

    private SpawnState state = SpawnState.COUNTING;

   
    void Start()
    {
        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No spawn points referenced");
        }

        waveCountdown = timeBetweenWaves;

    }

    void Update()
    {
        if(state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())
            {
                WaveCompleted();
               
            }
            else
            {
                return;
            }
        }

        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }

    }
    void WaveCompleted ()
    {
        if (nextWave + 1 > waves.Length - 1)
        {
            Debug.Log("ALL WAVES COMPLETE! LOOPING...");  
            SceneManager.LoadScene("WinScreen");
        }
        else
        {
            Debug.Log("Wave Completed!");
            canvasManager.GetComponent<canvasManager>().chooseCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            thisobject.SetActive(false);
            nextWave++;
        }

        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;

            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
        return true;
    }

    IEnumerator SpawnWave (Wave _wave)
    {
        Debug.Log("Spawning Wave : " + _wave.Name);
        GetComponent<AudioSource>().Play();
        state = SpawnState.SPAWNING;
        

        for (int i = 0; i < _wave.countEnemy1+ _wave.countEnemy2 + _wave.countEnemy3 + _wave.countEnemy4; i++)
        {
            if (i < _wave.countEnemy1)
            {
                SpawnEnemy(_wave.enemy1);
            }
           
            else if( i < _wave.countEnemy1 + _wave.countEnemy2)
            {
                SpawnEnemy(_wave.enemy2);
            }
            else if(i < _wave.countEnemy1 + _wave.countEnemy2 + _wave.countEnemy3)
            {
                SpawnEnemy(_wave.enemy3);
            }
            else
            {
                SpawnEnemy(_wave.enemy4);
            }
            yield return new WaitForSeconds(1f / _wave.rate);
        }
        

        state = SpawnState.WAITING;
        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        
        Debug.Log("Spawning Enemy: " + _enemy.name);

        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        

        Instantiate(_enemy, _sp.position, _sp.rotation);
        
    }

}
