using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update

   // [SerializeField] float xvalue = 0.00f;
    // [SerializeField] float yvalue = 0.01f;
   //  [SerializeField]  float zvalue = 0.00f;
   [SerializeField] float speed = 2f;
   
    void Start()
    {
        PrintInstruction();
    }
    
    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your Player with WASD or arrow Keys ");
        Debug.Log("Dont hit Walls . . . ");
    }


    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed ;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue,0,zValue);     
    }
}
