using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    Vector2 inputMov;
    public float velCamina = 10f;
    public float velCorre = 20f;

 
    void Start()
    {

      rb = GetComponent<Rigidbody>();


    }

    
    void Update()
    {

        inputMov.x = Input.GetAxis("Horizontal");
        inputMov.y = Input.GetAxis("Vertical");
        
    }



    private void FixedUpdate()
    {
      
      float vel = Input.GetKey(KeyCode.LeftShift) ? velCorre : velCamina;

      rb.velocity = transform.forward * vel * inputMov.y + transform.right * vel * inputMov.x;
      
      
    }

    
}
