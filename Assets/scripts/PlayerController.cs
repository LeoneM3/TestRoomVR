using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

   

    //movimiento 
    Rigidbody rb;
    public float velocidadMovimiento = 2.0f;
    public float velocidadRotacion = 200.0f;
    public float x, y;




    //camara
    public float horizontalSpeed;
    public float verticalSpeed;
    public Camera FPSCamara;
    float h;
    float v;

    //animacion

   




    void Start()
    {
        //logica corporal 
        rb = GetComponent<Rigidbody>();


        // animaciones

        


    }
    

  void Update() {



    //rotacion del mouse//
    h = horizontalSpeed * Input.GetAxis ("Mouse X"); 
    v = verticalSpeed * Input.GetAxis ("Mouse Y");

    transform.Rotate (0, h, 0);
    FPSCamara.transform.Rotate (-v, 0 ,0 );


        //movimiento del personaje

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

   

    }



  




}
