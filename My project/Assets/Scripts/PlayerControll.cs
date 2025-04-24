using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControll : MonoBehaviour 
{
    // starts game
    void Start()
    {

    }

        public int speed = 20; 
        public float turnSpeed = 40.0f; 
        public float horizontalInput;
        public float forwardInput; 

    

    //updtae per frame
    void Update()
    
    {
        // input defined 
        horizontalInput = Input.GetAxis("Horizontal"); 
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
        transform.Translate(Vector3.right * turnSpeed * horizontalInput * Time.deltaTime);

    }
}
