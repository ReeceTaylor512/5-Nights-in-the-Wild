using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firing : MonoBehaviour
{
    [SerializeField]
    private GameObject arrow;
    [SerializeField]
    private GameObject spawnPoint;

    public static float bowPower = 0.5f;
    [SerializeField]
    private float timeToMaxPower;

    [SerializeField]
    private Slider power; 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        fire();
    }

    void fire()
    {
        if (PauseMenu.paused == false)
        {
            //if(bowPower <= maxPower)
            if (Input.GetMouseButton(0))
            {                                 
               power.value += timeToMaxPower * Time.deltaTime;
               Debug.Log("LMB Held");
            }
            if(Input.GetMouseButtonUp(0))
            {
                Debug.Log("LMB Up");
                Instantiate(arrow, spawnPoint.transform.position, spawnPoint.transform.rotation);
                //bowPower = 0.5f; 
            }
           
        }
    }

}
