using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotLightController : MonoBehaviour
{

    public Light spotLight;

    
    // Start is called before the first frame update
    void Start()
    {
       spotLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
          spotLight.enabled = !spotLight.enabled;
        }
    
    }
}
