﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed=20;
    public Rigidbody2D sesuatu;
    void Start()
    {
		  sesuatu.velocity = new Vector2(-1,-1)*speed;    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other){
      if(other.collider.name=="TembokKanan"||other.collider.name=="TembokKiri"){
        GetComponent<Transform>().position = new Vector2(0,0);
      }
    }
}
