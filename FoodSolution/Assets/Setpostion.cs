using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setpostion : MonoBehaviour {
    public Vector3 A;
    public potatoClick potato;

    // Use this for initialization
    void Start()
    {
        transform.localPosition = A;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
