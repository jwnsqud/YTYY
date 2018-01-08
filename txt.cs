using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class txt : MonoBehaviour
{

    public GameObject talkP;
    public GameObject qqqq;

    public static bool T_F = true;
    public static bool B_T = false;
    
    public static int number;
    public static int B_number;
    public static int numbersave;


    public Text quest;
    public Text BUT1;
    public static string BUT1_VALUE;
    public Text BUT2;
    public static string BUT2_VALUE;
    public Text BUT3;
    public static string BUT3_VALUE;

    string[] all_lines;
    string[] but_lines;
    // Use this for initialization
    void Start()
    {

        
        all_lines = File.ReadAllLines(Application.dataPath + "/Resoureces/talkfile.txt");
        number = 0;
        but_lines = File.ReadAllLines(Application.dataPath + "/Resoureces/but.txt");
        B_number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true && B_T == false)
        {
            if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Space))
            {
                if (all_lines[number] == ":")
                {
                    B_T = true;

                }
                else if (all_lines[number] == ";")
                {
                   number=numbersave;
                    talkP.SetActive(false);
                    qqqq.SetActive(true);
                    T_F = true;
                }
                else if (all_lines[number] != "")
                { quest.text = all_lines[number];
                    number++;
                 }
                
                
                else
                {
                    talkP.SetActive(false);
                    number ++;
                    numbersave = number;
                }
               
                  
            }

        }
        if(B_T)
        {
            BUT1.text = but_lines[B_number];
            BUT1_VALUE = but_lines[B_number + 1];

            BUT2.text = but_lines[B_number + 2];
            BUT2_VALUE = but_lines[B_number + 3];

            BUT3.text = but_lines[B_number +4];
            BUT3_VALUE = but_lines[B_number + 5];


        }

    }
}