using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float forwardForce = 500f;
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    public float jumpForce = 500f;
    public Transform player;
    public float turnSpeed = 1.0f;
   // float rotationX = 0f;
    //float rotationY = 0f;

   // public float sensitivity = 15f;

    //public char " ";
   // public static KeyCode SpacebarKey() {
    //    if (Application.isEditor) return KeyCode.0 ;
    //    else return KeyCode.Space;
   // }
    // 
    void Start()
    {
        Debug.Log("Hello world");
    }
   // void LateUpdate()
   // {
   // if(Input.GetMouseButton(0))
     //   {
     //   float delta = Input.GetAxis("Mouse X") * turnSpeed;
     //   transform.RotateAround(player.transform.position, Vector3.up, 20 * Time.deltaTime);
     //   }
    //}

    // Update is called once per frame
    void Update()
    {
       // rotationY += Input.GetAxis("Mouse X") * sensitivity;
        //rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
       // transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
       
        if ( Input.GetKey("w")) {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if ( Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if ( Input.GetKey("a") ){
            rb.AddForce(-sidewaysForce * Time.deltaTime,0 ,0);
        }
        if ( Input.GetKey("s") ){
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if ( Input.GetKeyDown(KeyCode.Space) ) {
      
           rb.AddForce(0, jumpForce * Time.deltaTime, 0 );
        }
        if ( Input.GetKeyDown(KeyCode.Escape)) {
            
           Application.Quit();
        }
        
    
        }


    }


