using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    [SerializeField]
    private int privateInt;
    [SerializeField]
    protected string protectedStr;
    [HideInInspector]
    public int publicInt = 50;
    [HideInInspector]
    public string publicStr = "12313312311";
    private void Start()
    {
        print(privateInt);
        print(protectedStr);
    }
}
