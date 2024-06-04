using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print(this.transform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position +  this.transform.forward * 1 * Time.deltaTime;
    }
}
