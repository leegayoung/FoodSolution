using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delsprout : MonoBehaviour {
    public GameObject potato;
    int save = -1;
	// Use this for initialization
	void Start () {
        potato = new GameObject();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        //sub.GetComponent<Setpostion>().A = new Vector3(x, y, 0);
        PlayerPrefs.SetInt("selectBox", PlayerPrefs.GetInt("fullSprout"));
        potato = GameObject.Find("potato").GetComponent<potatoClick>().SproutDel[PlayerPrefs.GetInt("selectBox")];
        Debug.Log("선택된 박스 번호 : " + PlayerPrefs.GetInt("selectBox"));
        Destroy(potato);
        PlayerPrefs.SetInt("SproutCheck" + PlayerPrefs.GetInt("fullSprout"), 0);

    }
}
