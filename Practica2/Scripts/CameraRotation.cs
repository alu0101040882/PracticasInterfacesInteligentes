using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour
{

    public float rotationSpeed;

    void Start()
    {
        rotationSpeed = 1;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.F))
            this.transform.Rotate(Vector3.left * rotationSpeed);

        if(Input.GetKey(KeyCode.R))
            this.transform.Rotate(Vector3.right * rotationSpeed);
    }
}
