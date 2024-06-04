using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9_Exercises : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        //this.transform.Sort();
        print(this.transform.FindMyChild("kangkang"));
    }

    // Update is called once per frame
    void Update() {

    }
}

