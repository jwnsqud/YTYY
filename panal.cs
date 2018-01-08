using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panal : MonoBehaviour
{
    private int done;
    private float reset;
    public GameObject Talkbox;

    private void Start()
    {
        done = 2;
        reset = 0.0f;
        Talkbox.SetActive(false);
    }
    private void Update()
    {
        if (Announce.inform == true)
        {
            reset += Time.deltaTime;
            Talkbox.SetActive(true);
            if(reset>done)
            {
                Talkbox.SetActive(false);
                Announce.inform = false;
                reset = 0;
            }

        }

    }
}
