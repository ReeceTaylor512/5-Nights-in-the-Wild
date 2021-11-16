using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrowforce : MonoBehaviour
{
    private Rigidbody _rb;

    [SerializeField]
    private float force;
    //[SerializeField]
    private float destroyDelay = 5;

    [SerializeField]
    private Slider power;


    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        power = GameObject.Find("Slider").GetComponent<Slider>();
        ApplyForce();
        DestroyArrow();        
        Debug.Log(power);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ApplyForce()
    {
        _rb.AddForce(transform.right * power.value * 8.0f, ForceMode.Impulse);
        power.value =  0; 

    }
    void DestroyArrow()
    {
        Destroy(gameObject, destroyDelay);
    }

    

}
