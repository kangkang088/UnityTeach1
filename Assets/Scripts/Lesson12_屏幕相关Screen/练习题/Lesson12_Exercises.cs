using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lesson12_Exercises : MonoBehaviour {
    //看向的目标
    public Transform target;
    //镜头旋转速度
    public float rotateSpeed = 50;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        this.transform.LookAt(target);
        //检测鼠标右键长按
        if (Input.GetMouseButton(1)) {
            //围绕某一个点 的 某一个轴 旋转 多少度。
            this.transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime * Input.GetAxis("Mouse X"));
        }
    }
}
