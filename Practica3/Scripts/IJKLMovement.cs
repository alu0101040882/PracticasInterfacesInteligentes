using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IJKLMovement : MonoBehaviour
{
    Rigidbody rb;
   public  float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 50;
    }

    void FixedUpdate()
    {


        float moveHorizontal = 0;
        float moveVertical = 0;

        if (Input.GetKey(KeyCode.L))
        {
            moveHorizontal = 1.0f;
        }

        if (Input.GetKey(KeyCode.J))
        {
            moveHorizontal = -1.0f;
        }

        if (Input.GetKey(KeyCode.I))
        {
            moveVertical = 1.0f;
        }

        if (Input.GetKey(KeyCode.K))
        {
            moveVertical = -1.0f;
        }



        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

}
