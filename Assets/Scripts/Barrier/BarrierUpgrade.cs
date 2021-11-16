using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierUpgrade : MonoBehaviour
{
    [SerializeField]
    private GameObject barrier;
    private Vector3 scaleChange;
    [SerializeField]
    private int healthIncrease;
    [SerializeField]
    private int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        increaseScale();   
    }

    void increaseScale()
    {   
        if (UpgradeMenu.barrierHPIsUnlocked == true)
        {
            if (BarrierHealth.barrierHealth < maxHealth)
            {
                BarrierHealth.barrierHealth = BarrierHealth.barrierHealth += healthIncrease;
            }
            transform.localScale = new Vector3(10, 0.75f, 1.5f);
            transform.localPosition = new Vector3(-6, 0.9f, 2.77f);
            Debug.Log("If statement");           
        }       
    }

    
     
}
