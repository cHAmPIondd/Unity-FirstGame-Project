﻿using UnityEngine;
 using System.Collections;
 
 public class 第六关特殊踏板 : MonoBehaviour {
 
     private Rigidbody2D Rigidbody2D;
 	// Use this for initialization
 	void Start () {
 	    Rigidbody2D=GetComponent<Rigidbody2D>();
 	}
 	
 	// Update is called once per frame
 	void Update () {
 	    if(Rigidbody2D.velocity.y>0)
         {
             Rigidbody2D.velocity=Vector3.zero;
         }
 	}
 }
