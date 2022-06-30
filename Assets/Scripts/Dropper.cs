using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer renderer;
    private Rigidbody _rigidbody;
    [SerializeField] private float waitTime = 3f;
    void Start()
    {
        // this will disappear the components 
        renderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
        
        renderer.enabled = false;
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waitTime)
        {
            renderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}
