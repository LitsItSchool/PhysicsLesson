using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharC : MonoBehaviour {

    
    public CharacterController characterController;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //   characterController.SimpleMove(Vector3.forward);
        characterController.Move(Vector3.forward);
    }
}
