using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load : MonoBehaviour {
	// Use this for initialization
	 public GameObject Sprout;
     public  GameObject sub;
     public  bool[] SproutCheck= new bool[8];
	// Use this for initialization
	void Start () {
        makeSprout();
        sub.GetComponent<Setpostion>().A = new Vector3(100, 100, 0);
        Debug.Log(sub.GetComponent<Setpostion>().A);
        for (int i = 0; i < SproutCheck.Length;i++)
        {
            SproutCheck[i] = false;
        }
            
	}
	
	// Update is called once per frame
	void Update () {
	}

     public void makeSprout()
    {
    }
}
