﻿using UnityEngine;
using System.Collections;

public class StartMenuAnimator : MonoBehaviour 
{
    /**---------------------------------------------------------------------------------
     * Components necessary for animations
     */
    private Animator anim;
    private Rigidbody rb;
    private BoxCollider bc;
    
    /**---------------------------------------------------------------------------------
     * Executed when the script starts.
     * Takes the GameObject directly linked to this script and acquires the Animator component of that GameObject, then initiates the "Idle" animation.
     */
	void 
    Start() 
    {
        anim                    = gameObject.GetComponentInChildren<Animator>();
        anim.Play("Idle");
	}

    /**---------------------------------------------------------------------------------
     * Executed every frame.
     */
	void 
    Update () 
    {
	    //Empty
	}
}
