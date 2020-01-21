using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        Random.InitState(System.DateTime.Now.Millisecond);
    
        float moveHorizontal = Random.Range(-1.0f,1.0f);
        float moveVertical = Random.Range(-1.0f, 1.0f);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }


}
