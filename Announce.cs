using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Announce : MonoBehaviour {
    public static bool inform = false;
    

    public Text Alram;

	void Start () {

        //Alram = GetComponent<Text>();
        Alram.text = "획득한 증거품 : ";
    }
	
	// Update is called once per frame
	void Update ()
        {
        
        if (inform == true)
        {
            Alram.text = Route.target1 + "을 획득했다.";
           
        }
        
    }

    

}

