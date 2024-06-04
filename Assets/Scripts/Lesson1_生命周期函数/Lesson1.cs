using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    protected virtual void Awake()
    {
        Debug.Log("123");
        Debug.LogError("´íÎó£¡£¡£¡");
        Debug.LogWarning("¾¯¸æ£¡£¡£¡");
        print("Awake");
    }
    void OnEnable()
    {
        print("OnEnable");
    }
    // Start is called before the first frame update
    void Start()
    {
        print("Start");
    }
    void FixedUpdate()
    {
        print("FixedUpdate");
    }

    // Update is called once per frame
    void Update()
    {
        print("Update");
    }
    void LateUpdate()
    {
        print("LateUpdate");
    }
    void OnDisable()
    {
        print("OnDisable");
    }
    void OnDestroy()
    {
        print("OnDestroy");
    }
}
