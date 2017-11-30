using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potatoClick : MonoBehaviour {
    public GameObject Sprout;
    public GameObject sub;
    public GameObject[] SproutDel = new GameObject[8];
    public bool[] SproutCheck = new bool[8];
    public int[,]SproutPostion= new int[8,3];
    public int a = 100;
    int x ,y , Boxcnt ,  fullSprout;

	// Use this for initialization
	void Start () 
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < 8; i++)
        {
            SproutDel[i] = GameObject.Find("Sprout" + i);
        }
	}

     void OnClick()
     {
          Boxcnt = PlayerPrefs.GetInt("SproutPostionCnt", 0);
          fullSprout = PlayerPrefs.GetInt("fullSprout");
          x = PlayerPrefs.GetInt("SproutPostionX"+fullSprout, 0);
          y = PlayerPrefs.GetInt("SproutPostionY"+fullSprout, 0);
          if ((PlayerPrefs.GetInt("SproutCheck" + fullSprout, 0)) == 0) //0이었을때가 안심어졌을때 1이었을때가 심어졌있음
         {
             sub = (GameObject)Instantiate(Sprout);
             sub.GetComponent<Setpostion>().A = new Vector3(x, y, 0);
             Debug.Log(x);
             sub.name = "Sprout" + fullSprout;
          }
         PlayerPrefs.SetInt("SproutCheck" + fullSprout, 1);
         SproutPostion[fullSprout, 0] = x;
         SproutPostion[fullSprout, 1] = y;
         SproutPostion[fullSprout, 2] = 0;

        // SproutDel[1] = GameObject.Find("SproutCheck1");
     }
}
