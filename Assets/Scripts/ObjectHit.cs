using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   // we dont need Start and update method 

   private void OnCollisionEnter(Collision collision)
   {
      // unity take its place when ever collider (Player) interact with the wall we trigger this method 
      // very useful method to trigger when two object touch collide with each other 
      // how ever how we specify an object of an other ?
     
      
      // we can access the Componenet by using the KeyWord GetComponent 
      if (collision.gameObject.tag == "Player")
      {
         GetComponent<MeshRenderer>().material.color = Color.red;
         gameObject.tag = "Hit";
      }
      
      
   }
}
