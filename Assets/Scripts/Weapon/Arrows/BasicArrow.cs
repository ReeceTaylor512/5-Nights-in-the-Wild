using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicArrow : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private GameObject enemyTypeTwo;
    [SerializeField]
    private int damage; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Enemy"))
        {
            
            EnemyHealth _EH = other.gameObject.GetComponent<EnemyHealth>();
            _EH.health -= damage; 
        }
    }


}
