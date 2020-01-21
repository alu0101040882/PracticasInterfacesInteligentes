using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
	 public Button boton;
	 public Text poder,dinero;
	
    // Start is called before the first frame update
    void Start()
    {
        boton.onClick.AddListener(buy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void buy(){
		int Idinero = int.Parse(dinero.text);
		int Ipoder = int.Parse(poder.text);
		
		if(Idinero > 100){
			Idinero-=100;
			Ipoder+=1;
		}
		
		poder.text = Ipoder.ToString();
		dinero.text = Idinero.ToString();
		
	}
}
