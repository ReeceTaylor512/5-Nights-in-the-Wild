using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class EnemyHealth : MonoBehaviour, IPooledObject
{
    public int health;

    [SerializeField]
    private TextMeshProUGUI healthText;

    private Transform barrier;

    private float attackDelay = 3.0f;
    private float timer; 

    private void Awake()
    {
        healthText = transform.Find("Canvas/Health (TMP)").GetComponent<TextMeshProUGUI>();
        barrier = GameObject.Find("Barrier").transform; 
    }

    public void OnObjectSpawn(){}

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString("F0");
        death();
        AttackBarrier();
    }

    

    void death()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Score.score = Score.score + 100;
            Coin.coin = Coin.coin + Random.Range(500, 1000);
            SceneTransition.enemyCount -= 1;           
        }
    }

    void AttackBarrier()
    {
        float distToBarrier = Vector3.Distance(barrier.position, transform.position);
        Debug.Log(distToBarrier);
        if(distToBarrier < 4.0f)
        {
            timer += Time.deltaTime;
            if(timer > attackDelay)
            {
                BarrierHealth.barrierHealth -= 1.0f;
                timer = 0.0f;
                Debug.Log("Damaging");
            }
        }
    }
}
