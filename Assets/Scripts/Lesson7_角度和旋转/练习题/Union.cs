using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Union : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(new Vector3(0,0,0),Vector3.up,10*Time.deltaTime);
    }
}
