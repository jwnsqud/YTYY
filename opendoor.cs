using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour {

    public static int Object_num;
    public static int Count_num;

	// Use this for initialization
	void Start () {
        Object_num = 3;//숫자에 씬의 오브젝트 숫자 적용
	}
	
	// Update is called once per frame
	void Update () {

        if (Count_num == Object_num)
        {
            Debug.Log("ddfas");//문여는 메소드 트루값으루라다 넣어버리기~
        }
		
	}

    public void counter()
    {
        Count_num = 0;
    }
}
