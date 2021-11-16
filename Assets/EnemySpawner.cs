using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    private void Start()
    {
       // objectPooler = ObjectPooler.Instance; 

    }
    // Update is called once per frame
    void FixedUpdate()
    {
       // objectPooler.SpawnFromPool("Enemy", transform.position, Quaternion.identity);
    }
}
