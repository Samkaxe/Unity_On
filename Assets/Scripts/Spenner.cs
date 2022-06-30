using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spenner : MonoBehaviour
{
   [SerializeField] private float xRotate ;
   [SerializeField] private float yRotate;
   [SerializeField] private float zRotate;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotate,yRotate,zRotate);
    }
}
