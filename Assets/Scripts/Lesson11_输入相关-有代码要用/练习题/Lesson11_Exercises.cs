using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11_Exercises : MonoBehaviour {
    public float moveSpeed = 10;
    public float rotateSpeed = 10;
    public float headRotateSpeed = 50;
    public Transform pkPos;
    public Transform head;
    public float pkRotateSpeed = 20;

    public GameObject bulletObj;
    public Transform bulletPos;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //Input.GetAxis("Horizontal");
        //Input.GetAxis("Vertical");
        this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.Self);
        //this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.Self);
        this.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        head.Rotate(Vector3.up * headRotateSpeed * Time.deltaTime * Input.GetAxis("Mouse X"));

        //ÅÚ¹Ü
        pkPos.Rotate(Vector3.right * pkRotateSpeed * Time.deltaTime * Input.mouseScrollDelta.y, Space.Self);

        #region Lesson16 Á·Ï°Ìâ1
        if (Input.GetMouseButtonDown(0)) {
            GameObject obj = Instantiate(bulletObj);
            obj.transform.position = bulletPos.position;
            obj.transform.eulerAngles = bulletPos.eulerAngles;
        }

        #endregion
    }
}
