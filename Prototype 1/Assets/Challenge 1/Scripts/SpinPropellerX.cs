﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    
     public GameObject propeller;
    // private Vector3 offset = new Vector3(0, 0, 5);
    public float speed = 180f;
    public float increase = 50f;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Propellers Velocity
        transform.Rotate(Vector3.forward * speed * increase * Time.deltaTime);
        //transform.rotation = propeller.transform.rotation;
     
    }

}