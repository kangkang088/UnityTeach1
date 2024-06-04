using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Lesson3_Test[] lesson3_Tests = this.GetComponentsInChildren<Lesson3_Test>(true);
        print(lesson3_Tests.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
