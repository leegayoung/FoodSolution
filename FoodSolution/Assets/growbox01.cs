using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growbox01 : MonoBehaviour {
    public GameObject[] box = null;
    int cnt = 6; //나중에 고치자~~
    public potatoClick potato;
    public Setpostion setpos;

    // Use this for initialization

    void Awake()
    {
        Debug.Log(gameObject.name);
        box = new GameObject[cnt]; // 블러처리하는 창이랑 선택한 창과 물이랑 삭제랑 고구마랑 감자
        box[0] = GameObject.Find("blur");
        box[1] = GameObject.Find("window");
        box[2] = GameObject.Find("water");
        box[3] = GameObject.Find("potato");
        box[4] = GameObject.Find("del");
        box[5] = GameObject.Find("delsprout");

        //    GameObject tilePrefab = Resources.Load("prefebs/sprout") as GameObject;
    }

    void Start()
    {
        //potato = GameObject.Find("PotatoSp").GetComponent<potatoClick>();
        //potato.SproutPostion[1, 0] = x;
        //potato.SproutPostion[1, 1] = y;
        //potato.SproutPostion[1, 2] = 0;
    }

    void OnClick()
    {
      
      //   setpos.Setpos(1, -423, 407);
        Transform transform = GetComponent<Transform>();
        Vector3 vector = transform.position;
        for (int i = 0; i < cnt; i++)
        {
            box[i].gameObject.SetActive(true);
        }
        box[1].transform.localPosition = new Vector3(-423, 407, 0); //메인 카메라와 ngui의 카메라가 다름
        PlayerPrefs.SetInt("SproutPostionX1", -423);
        PlayerPrefs.SetInt("SproutPostionY1", 407);
        PlayerPrefs.SetInt("fullSprout", 1);
    }
}
