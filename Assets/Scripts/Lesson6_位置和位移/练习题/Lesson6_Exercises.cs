using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6_Exercises : MonoBehaviour {
    public int n = 1;
    // Start is called before the first frame update
    void Start() {
        //决定层数
        for (int i = 0; i < n; i++) {
            Vector3 pos = new Vector3(-0.5f * i, -1f * i, 0.5f * i);
            //决定每层多少个立方体
            for (int j = 0; j < (i + 1) * (i + 1); j++) {
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                obj.transform.position = pos + new Vector3(j % (i + 1) * 1, 0, j / (i + 1) * -1);
            }
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
