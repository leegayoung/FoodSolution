using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growbox00 : MonoBehaviour {
    public GameObject[] box = null;
     int cnt = 6; //나중에 고치자~~
    public potatoClick potato;
    public GameObject Sprout;
    public GameObject sub;

    // Use this for initialization

    void Awake()
    {
        for (int i = 0; i < 8; i++)
        {
            if ((PlayerPrefs.GetInt("SproutCheck" + i, 0)) == 1)
            {
                int x = PlayerPrefs.GetInt("SproutPostionX" + i, 0);
                int y = PlayerPrefs.GetInt("SproutPostionY" + i, 0);
                sub = (GameObject)Instantiate(Sprout);
                sub.GetComponent<Setpostion>().A = new Vector3(x, y, 0);
                sub.name = "Sprout" + i;
            }
        }
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
        for (int i = 0; i < cnt; i++)
        {
            box[i].gameObject.SetActive(false);
        }
    }

    void OnClick()
    {
        Debug.Log(potato.SproutPostion[1, 1]);
        Transform transform = GetComponent<Transform>();
        Vector3 vector = transform.position;
        for (int i = 0; i < cnt; i++)
        {
            box[i].gameObject.SetActive(true);
        }
        box[1].transform.localPosition = new Vector3(-1002, 407, 0); //메인 카메라와 ngui의 카메라가 다름
        PlayerPrefs.SetInt("SproutPostionX0", -1002);
        PlayerPrefs.SetInt("SproutPostionY0", 407);
        PlayerPrefs.SetInt("fullSprout", 0);

    }
}
