using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{
    public LayerMask mask; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseLook(); 
    }

    void mouseLook()
    {
        if (PauseMenu.paused == false)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Physics.Raycast(ray, out hit, Mathf.Infinity, mask);

            if (hit.point != null)
            {
                Vector3 lookPos = new Vector3(hit.point.x, 2.04f, hit.point.z);
                transform.LookAt(lookPos);
            }
        }
    }
    
}
