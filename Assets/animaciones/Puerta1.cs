﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta1 : MonoBehaviour
{
    public float speed = 1;
    public float angle;
    public Vector3 direcction;
    public bool abrir;
    public bool puedeAbrir;


    // Start is called before the first frame update
    void Start()
    {
        angle = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Round(transform.eulerAngles.y) != angle)
        {
            transform.Rotate(direcction * speed);
        }

        if (Input.GetButtonDown("Fire1") && abrir == false && puedeAbrir == true)
        {
            angle = 90;
            direcction = Vector3.up;
            abrir = true;
        }
        else if(Input.GetButtonDown("Fire1") && abrir == true && puedeAbrir == true)
        {
            angle = 0;
            direcction = Vector3.down;
            abrir = false;
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            puedeAbrir = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            puedeAbrir = false;
        }
    }

}
