using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{

    public float speed;

    
    void Start()
    {
        speed = 1;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        this.transform.position += movement*speed;


    }


}
