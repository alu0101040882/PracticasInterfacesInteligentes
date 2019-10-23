using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetector : MonoBehaviour
{

    private Renderer renderer;
    float speed;
    void Start()
    {

        renderer = GetComponent<Renderer>();

    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Sphere")
        {
            renderer.material.SetColor("_Color", Color.red);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Sphere")
        {
            renderer.material.SetColor("_Color", Color.white);
        }

    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Sphere")
        {
            renderer.material.SetColor("_Color", Color.blue);
        }

     }
    
}
