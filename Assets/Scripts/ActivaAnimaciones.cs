using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivaAnimaciones : MonoBehaviour {

    Animator controller;

	// Use this for initialization
	void Start () {

        controller = GetComponent<Animator>();
        if(controller == null)
        {
            Debug.Log("Error: No tienes un animator.");
        }

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump"))
        {
            
            controller.SetBool("Descansa", false);
        }


	}
}
