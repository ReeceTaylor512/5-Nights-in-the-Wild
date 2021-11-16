using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class WaveSpawner : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public enum SpawnState { SPAWNING, WAITING, COUNTING }


    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public Transform enemyTwo;
        public Transform boss;
        public int count;
        public float rate; 
    }
   

    

    public Wave[] waves;
    //public Enemy[] enemies; 
    private int nextWave = 0;

    public Transform[] spawnPoints; 

    public float timeBetweenWaves = 5.0f;
    private float waveCountdown;
    private float searchCountdown = 1.0f;

    private SpawnState state = SpawnState.COUNTING;

    // Start is called before the first frame update
    void Start()
    {
        waveCountdown = timeBetweenWaves;
       // countText = transform.Find("HUDCanvas/Count (TMP)").GetComponent<TextMeshProUGUI>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(state == SpawnState.WAITING)
        {
            if(!EnemyIsAlive())
            {
                WaveCompleted();
                
                return; 
            }
            else
            {
                return;
            }
        }

        if(waveCountdown <= 0)
        {
            if(state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[nextWave])); 
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }

        //int enemyCount;
        //Wave _enemyCount.count;
        //enemyCount = _enemyCount.count;
        //countText.text = _wave
       
    }

    void WaveCompleted()
    {
        Debug.Log("Wave Completed!");
        SceneManager.LoadScene(3);

        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves; 

        if(nextWave + 1 > waves.Length -1)
        {
            nextWave = 0;
            Debug.Log("Completed all waves.");
        }
        else
        {
            nextWave++;

        }

        nextWave++; 


    }
    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0)
        {
            searchCountdown = 1.0f; 
            if (GameObject.FindGameObjectsWithTag("Enemy") == null)
            {
                return false;
                
            }
        }
        return true;
    }

    IEnumerator SpawnWave (Wave _wave)
    {
        Debug.Log("Spawning Wave: " + _wave.name);
        state = SpawnState.SPAWNING;

        for(int i = 0; i < _wave.count; i++)
        {
           SpawnEnemy(_wave.enemy);
            //SpawnEnemy(_enemy.enemyTwo);
           //SpawnEnemy(_enemy.boss);
            yield return new WaitForSeconds(1.0f / _wave.rate); 
        }

        state = SpawnState.WAITING;

        yield break;
    }

   

    void SpawnEnemy(Transform _enemy)
    {

        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemy, _sp.position, _sp.rotation);
        Debug.Log("Spawning Enemy: " + _enemy.name);
    }

    void SpawnEnemyTwo(Transform _enemyTwo)
    {

        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemyTwo, _sp.position, _sp.rotation);
        Debug.Log("Spawning Enemy: " + _enemyTwo.name);
    }
    void SpawnBoss(Transform _boss)
    {

        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_boss, _sp.position, _sp.rotation);
        Debug.Log("Spawning Enemy: " + _boss.name);
    }   
}
