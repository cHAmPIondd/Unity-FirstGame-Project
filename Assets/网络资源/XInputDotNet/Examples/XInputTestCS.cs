using UnityEngine;
 using XInputDotNetPure; // Required in C#
 
 public class XInputTestCS : MonoBehaviour
 {
 
     PlayerIndex playerIndex=PlayerIndex.Two;
     GamePadState state;
 
     public bool a;
     public float big = 10;
     // Update is called once per frame
     void Update()
     {
     
         state = GamePad.GetState(playerIndex);
         if(a)
              GamePad.SetVibration(playerIndex, 0f, 0f);
         else
             GamePad.SetVibration(playerIndex, big, big);
     }
 
 
 }
