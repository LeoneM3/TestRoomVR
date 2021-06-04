using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Camera FPSCamara;
    Rigidbody rb;
    Vector2 inputMov;

    public float velCamina = 10f;
    public float velCorre = 20f;


    public float horizontalSpeed;
    public float verticalSpeed;

    float h;
    float v;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    

  void Update() {



    //rotacion del mouse//
    h = horizontalSpeed * Input.GetAxis ("Mouse X"); 
    v = verticalSpeed * Input.GetAxis ("Mouse Y");

    transform.Rotate (0, h, 0);
    FPSCamara.transform.Rotate (-v, 0 ,0 );


        //movimiento del personaje

        inputMov.x = Input.GetAxis("Horizontal");
        inputMov.y = Input.GetAxis("Vertical");




   }


   private void FixedUpdate()
    {
        //controladores
        float vel = Input.GetKey(KeyCode.LeftShift) ? velCorre : velCamina;

         rb.velocity =
            transform.forward * vel * inputMov.y
            + transform.right * vel * inputMov.x;

    }

}
