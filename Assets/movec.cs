﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movec : MonoBehaviour {
    public float v=2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * v * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * v * Time.deltaTime);
        }
	}
}
