using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    public GameObject myObj;
    // Start is called before the first frame update
    void Start()
    {
        print(this.gameObject.name);
        this.gameObject.name = "kangkang";
        print(this.gameObject.name);
        print(this.gameObject.activeSelf);
        print(this.gameObject.isStatic);
        print(this.gameObject.layer);
        print(this.gameObject.tag);
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "own cube";

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print(objs.Length);

        GameObject.Instantiate(myObj);
        //Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
