using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonAroundEarth : MonoBehaviour {
    GameObject obj;
    // Start is called before the first frame update
    void Start() {
         obj = GameObject.Find("Union");
    }

    // Update is called once per frame
    void Update() {

        this.transform.RotateAround(obj.transform.localPosition, Vector3.up, 10 * Time.deltaTime);
    }
}
