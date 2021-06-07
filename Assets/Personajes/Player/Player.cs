using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public float VelMov = 2.0f;
    public float VelRot = 200.0f;

    private Animator anim;
    public float x, y;


    //camara
    public float horizontalSpeed;
    public float verticalSpeed;
    public Camera FPSCamara;
    float h;
    float v;


    // Start is called before the first frame update
    void Start()
    {


        anim = GetComponent<Animator>();



    }

    // Update is called once per frame
    void Update()
    {



        //rotacion del mouse//
        h = horizontalSpeed * Input.GetAxis("Mouse X");
        v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        FPSCamara.transform.Rotate(-v, 0, 0);

        //movimiento
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * VelRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * VelMov);



        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);




    }
}
