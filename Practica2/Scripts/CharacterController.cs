using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;

    
    void Start()
    {
        speed = 1;
        rotationSpeed = 3;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        this.transform.position += movement*speed;

        if(Input.GetKey(KeyCode.F))
            this.transform.Rotate(Vector3.up * rotationSpeed);

        if(Input.GetKey(KeyCode.R))
            this.transform.Rotate(Vector3.down * rotationSpeed);


    }


}
