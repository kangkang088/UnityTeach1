using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //print(Time.deltaTime);
    }
    void FixedUpdate()
    {
        print(Time.fixedDeltaTime);
        print(Time.fixedUnscaledDeltaTime);
    }
}
