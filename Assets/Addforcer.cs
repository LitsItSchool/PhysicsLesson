using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addforcer : MonoBehaviour {
    public Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
        }
	}
}
