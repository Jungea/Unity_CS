using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour {
    float speed = 30.0f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        // 키보드 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 이동거리 보정
        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        // 회전
        transform.rotation *= Quaternion.AngleAxis(h, Vector3.back);  // Horizontal -Z axis
        transform.rotation *= Quaternion.AngleAxis(v, Vector3.right);  // Verticla - X axis
    }
}