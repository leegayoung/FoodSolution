using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour {
    UISprite _sprite;
    GameObject img;
    bool b = true;

    void Awake()
    {
         img = GameObject.Find("left");
        _sprite = GetComponent<UISprite>();
        img.gameObject.SetActive(b);
        Debug.Log("ok1");

    }
  
    // Use this for initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
	// Update is called once per frame
	void Update () {
		
	}


    public void ButtonOnoff()
    {
        Debug.Log("ok2");
        if (b)
        {
            img.gameObject.SetActive(b);
            b = false;
        }
        else
        {
            img.gameObject.SetActive(b);
            b = true;
        }
    }

    public void GotoGrow()
    {
        SceneManager.LoadScene(1);
    }
}
