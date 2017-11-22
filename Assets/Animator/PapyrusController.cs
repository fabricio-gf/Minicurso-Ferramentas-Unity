using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PapyrusController : MonoBehaviour {

    public Animator controller;

    void Start()
    {
        //controller.GetComponent<Animator>();
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            controller.SetBool("WalkDown", true);
            controller.SetBool("WalkLeft", false);
            controller.SetBool("WalkRight", false);
            controller.SetBool("WalkUp", false);
            controller.SetBool("Idle", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            controller.SetBool("WalkLeft", true);
            controller.SetBool("WalkDown", false);
            controller.SetBool("WalkRight", false);
            controller.SetBool("WalkUp", false);
            controller.SetBool("Idle", false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            controller.SetBool("WalkRight", true);
            controller.SetBool("WalkDown", false);
            controller.SetBool("WalkLeft", false);
            controller.SetBool("WalkUp", false);
            controller.SetBool("Idle", false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            controller.SetBool("WalkUp", true);
            controller.SetBool("WalkDown", false);
            controller.SetBool("WalkLeft", false);
            controller.SetBool("WalkRight", false);
            controller.SetBool("Idle", false);
        }

        if(!Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow))
        {
            controller.SetBool("Idle", true);
            controller.SetBool("WalkUp", false);
            controller.SetBool("WalkDown", false);
            controller.SetBool("WalkLeft", false);
            controller.SetBool("WalkRight", false);
        }
    }
}
