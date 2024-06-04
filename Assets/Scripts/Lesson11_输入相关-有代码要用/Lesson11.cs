using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.mousePosition);

        //if (Input.GetMouseButtonDown(0)) {
        //    print("左键按下了");
        //}

        //print(Input.GetAxis("Horizontal"));

        //print(Input.GetAxis("Mouse X"));

        //if (Input.anyKey) {
        //    print("有一个键按下");
        //}

        if (Input.anyKeyDown) {
            print("有一个键按下");
            print("这个键是： " + Input.inputString);
        }
    }
}
