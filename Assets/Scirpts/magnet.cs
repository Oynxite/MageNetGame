﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour
{
    public GameObject Magnet;
    public float forceFactor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce((Magnet.transform.position - transform.position) * forceFactor * Time.smoothDeltaTime);
    }
}