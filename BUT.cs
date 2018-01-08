using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BUT : MonoBehaviour
{
    
    public GameObject B3P;
    public Text BUT3_1;
    public Text BUT3_2;
    public Text BUT3_3;
    public Text quest;
    // Use this for initialization
    void Start()
    {

    }
    public void Bu1()
    {
        if(txt.BUT1_VALUE=="true")
        {
            txt.number += 3;
          
            txt.B_number += 7;
           
        }
        else
        {
            ++txt.number;
           
        }
        txt.B_T = false;
    }
    public void Bu2()
    {
        if (txt.BUT2_VALUE == "true")
        {
            txt.number += 3;
            txt.B_number += 7;
           
        }
        else
        {
            ++txt.number;
          
        }
        txt.B_T = false;

    }


    public void Bu3()
    {
        if (txt.BUT3_VALUE == "true")
        {

            txt.number += 3;
            txt.B_number += 7;
          
        }
        else
        {
            ++txt.number;
           
        }
        txt.B_T = false;
       

    }




    // Update is called once per frame
    void Update()
    {
       
        if (txt.B_T == true)
            
            B3P.SetActive(true);
        }
        else
            B3P.SetActive(false);

    }

}
