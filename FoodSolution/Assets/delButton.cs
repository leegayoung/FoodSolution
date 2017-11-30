using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delButton : MonoBehaviour {

    public GameObject[] box = null;
     int cnt = 6; //나중에 고치자~~

    // Use this for initialization

    void Awake()
    {
    }

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        Debug.Log("클릭됨");
        box = new GameObject[cnt]; // 블러처리하는 창이랑 선택한 창과 물이랑 삭제랑 고구마랑 감자
        box[0] = GameObject.Find("blur");
        box[1] = GameObject.Find("window");
        box[2] = GameObject.Find("water");
        box[3] = GameObject.Find("potato");
        box[4] = GameObject.Find("del");
        box[5] = GameObject.Find("delsprout");

        for (int i = 0; i < cnt; i++)
        {
            box[i].gameObject.SetActive(false);
        }
    }
}
