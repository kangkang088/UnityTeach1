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
        //    print("���������");
        //}

        //print(Input.GetAxis("Horizontal"));

        //print(Input.GetAxis("Mouse X"));

        //if (Input.anyKey) {
        //    print("��һ��������");
        //}

        if (Input.anyKeyDown) {
            print("��һ��������");
            print("������ǣ� " + Input.inputString);
        }
    }
}
