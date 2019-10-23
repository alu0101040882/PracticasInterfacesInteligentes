using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCounter : MonoBehaviour
{
    public int collisionCount;

    void Start()
    {
        collisionCount = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Sphere")
        {
 
            collisionCount++;
            Debug.Log(collisionCount);

        }
    }
}
