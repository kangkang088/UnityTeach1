using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7_Exercises : MonoBehaviour {
    public int upOrDown = 1;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        this.transform.Rotate(Vector3.up, 10 * Time.deltaTime);
    }
}
