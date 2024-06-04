using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson7_guanzi : MonoBehaviour {
    public Lesson7_Exercises obj;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (obj != null && obj.upOrDown <= 0)
            this.transform.Rotate(Vector3.right, 10 * Time.deltaTime);
        else if (obj != null && obj.upOrDown > 0)
            this.transform.Rotate(Vector3.right * -1, 10 * Time.deltaTime);
    }
}
