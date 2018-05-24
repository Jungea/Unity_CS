using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var angle = Input.acceleration.y * 60;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);  // Horizontal -Z axis
    }
}