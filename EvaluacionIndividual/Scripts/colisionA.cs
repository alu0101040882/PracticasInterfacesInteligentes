using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionA : MonoBehaviour
{
	
	public int poder = 10;
	public GameObject C;
	Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = C.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
		  
      Vector3 movement = new Vector3(0,poder*100,0);

      rb.AddForce(movement);
    }
}
