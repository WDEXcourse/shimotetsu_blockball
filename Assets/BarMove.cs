using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMove : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(3,0,0,ForceMode.Impulse);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-3,0,0,ForceMode.Impulse);
        }
    }
}
