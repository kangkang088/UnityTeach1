using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lesson12_Exercises : MonoBehaviour {
    //�����Ŀ��
    public Transform target;
    //��ͷ��ת�ٶ�
    public float rotateSpeed = 50;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        this.transform.LookAt(target);
        //�������Ҽ�����
        if (Input.GetMouseButton(1)) {
            //Χ��ĳһ���� �� ĳһ���� ��ת ���ٶȡ�
            this.transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime * Input.GetAxis("Mouse X"));
        }
    }
}
