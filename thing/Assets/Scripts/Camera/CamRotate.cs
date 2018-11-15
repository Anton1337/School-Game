using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour {

    [SerializeField]
    private KeyCode rotateLeft;
    [SerializeField]
    private KeyCode rotateRight;
    [SerializeField]
    private float rotateDegreesPerSecond;
	
	void Update () {
        Rotate();
	}

    private void Rotate()
    {
        if (Input.GetKey(rotateLeft))
        {
            transform.Rotate(new Vector3(0, 0, rotateDegreesPerSecond * Time.deltaTime));
        }
        if (Input.GetKey(rotateRight))
        {
            transform.Rotate(new Vector3(0, 0, -rotateDegreesPerSecond * Time.deltaTime));
        }
    }
}
