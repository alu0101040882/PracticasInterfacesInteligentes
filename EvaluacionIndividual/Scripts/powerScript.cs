using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerScript : MonoBehaviour
{
    public int collisionCount;
    public Text texto;
	public Text dinero;

    delegate void PowerDelegate();
    PowerDelegate powerDelegate;

    void Start()
    {
        collisionCount = 0;

    }
	


    void powerStay()
    {
        Debug.Log(collisionCount);
    }

    void powerUp()
    {
        collisionCount++;
        texto.text = collisionCount.ToString();
        Debug.Log(collisionCount);
    }

    void powerDown()
    {

        collisionCount = collisionCount - 1 < 0 ? 0 : collisionCount - 1;
        texto.text = collisionCount.ToString();
        Debug.Log(collisionCount);
    }
	
	

    void OnCollisionEnter(Collision collision)
    {
		
		


        if (collision.gameObject.tag == "Coin")
        {

            powerDelegate = powerUp;

        }
        else
        if (collision.gameObject.tag == "Mummy")
        {

            powerDelegate = powerDown;

        }
        else
        {
            powerDelegate = powerStay;
        }

        powerDelegate();
    }
	
	 void OnCollisionStay(Collision collision)
    {
		int poder = int.Parse(texto.text);

		if (Input.GetKeyDown(KeyCode.E))
        {
			
            if (collision.gameObject.tag == "A"){
				Transform transform = collision.gameObject.GetComponent<Transform>();
				transform.localScale += new Vector3(0.1f * -poder,0.1f * -poder, 0.1f*-poder);
				collision.gameObject.GetComponent<colisionA>().poder++;

			}
        }
		
	    if (Input.GetKeyDown(KeyCode.Q))
        {
           if (collision.gameObject.tag == "B"){
			   powerDown();
			   int Idinero = int.Parse(dinero.text);
			   Idinero+=100;
			   dinero.text = Idinero.ToString();
			   Renderer renderer = collision.gameObject.GetComponent<Renderer>();
			   renderer.material.SetColor("_Color", Color.red);
			}
        }
    }
}
