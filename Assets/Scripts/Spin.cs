using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {
    public float SpinSpeed;	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, SpinSpeed);
	}
}
