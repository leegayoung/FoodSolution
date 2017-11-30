using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escGame : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetString("EndTime", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            Debug.Log(PlayerPrefs.GetString("EndTime"));

            Application.Quit();
        }
    }
}