using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuletObj : MonoBehaviour {
    public float moveSpeed = 10;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision) {

    }
    private void OnTriggerEnter(Collider other) {
        //碰撞到地面，消失
        if (other.gameObject.CompareTag("Ground")
            || other.gameObject.CompareTag("Monster")) {
            Destroy(this.gameObject);
        }
    }
}
