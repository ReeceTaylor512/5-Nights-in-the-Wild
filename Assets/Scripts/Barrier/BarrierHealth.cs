using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BarrierHealth : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy;
    public static float barrierHealth;

    private bool barrierIsDead; 

    public TextMeshProUGUI barrierHealthText;

    // Start is called before the first frame update
    void Start()
    {
        barrierHealth = 100;
        barrierHealthText = transform.Find("Canvas/Health (TMP)").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        barrierHealthText.text = barrierHealth.ToString("F0");
        Death();
    }

    void Death()
    {
        if(barrierHealth <= 0)
        {
            barrierIsDead = true; 
        }
        if (barrierIsDead == true)
        {
            SceneManager.LoadScene(3);

        }

    }
   
}
