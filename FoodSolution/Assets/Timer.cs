using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    public GameObject potato;
    public float[] SproutTime = new float[8];
    float fTime = 0;
	// Use this for initialization
	void Start () {
        string EndTime = PlayerPrefs.GetString("EndTime");
        System.DateTime EndDateTime = System.DateTime.Parse(EndTime);
        System.TimeSpan compareTime = System.DateTime.Now - EndDateTime;


         fTime = Time.deltaTime;
         for (int i = 0; i < 8; i++)
             SproutTime[i] = PlayerPrefs.GetInt("Time" + i,0);
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < 8; i++)
        {
            if(PlayerPrefs.GetInt("SproutCheck" + i, 0) == 1)
            {
                SproutTime[i] += Time.deltaTime;
                PlayerPrefs.SetFloat("Time" + i, SproutTime[i]);
                //Debug.Log(i + "의 시간 : " + SproutTime[i]);
            }

        }
	}
}
