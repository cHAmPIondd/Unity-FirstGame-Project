﻿using UnityEngine;
 using System.Collections;
 
 public class 读取关卡 : MonoBehaviour {
 
     public GameObject[] 关卡预设体;
     public void 载入关卡(int n)
     {
         switch(n)
         {
             case 1: Destroy(GameObject.Find("第一关")); Instantiate(关卡预设体[n - 1], new Vector3(0, 0, 0), Quaternion.identity); break;
             case 2: Destroy(GameObject.Find("第二关")); Instantiate(关卡预设体[n - 1], new Vector3(0, 0, 0), Quaternion.identity); break;
             case 3: Destroy(GameObject.Find("第三关")); Instantiate(关卡预设体[n - 1], new Vector3(0, 0, 0), Quaternion.identity); break;
             case 4: Destroy(GameObject.Find("第四关")); Instantiate(关卡预设体[n - 1], new Vector3(0, 0, 0), Quaternion.identity); break;
             case 5: Destroy(GameObject.Find("第五关")); Instantiate(关卡预设体[n - 1], new Vector3(0, 0, 0), Quaternion.identity); break;
             case 6: Destroy(GameObject.Find("第六关")); Instantiate(关卡预设体[n - 1], new Vector3(0, 0, 0), Quaternion.identity); break;
         }
     }
 	// Use this for initialization
 	void Start () {
 	}
 	
 	// Update is called once per frame
 	void Update () {
 	
 	}
 }
