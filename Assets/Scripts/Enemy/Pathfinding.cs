using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{

    private GameObject target;
    public NavMeshAgent enemy;
  

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Barrier");
        enemy.SetDestination(target.transform.position);


    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

   
 
    
       
            
       

    
    
}
