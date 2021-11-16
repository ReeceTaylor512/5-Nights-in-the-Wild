using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraDamage : MonoBehaviour
{
    [SerializeField]
    private int extraDamage;
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
        if (UpgradeMenu.damageIsUnlocked == true)
        {           

            if (other.gameObject.name.Contains("Enemy"))
            {

                EnemyHealth _EH = other.gameObject.GetComponent<EnemyHealth>();
                _EH.health -= extraDamage;
            }
        }
        
    }
}
