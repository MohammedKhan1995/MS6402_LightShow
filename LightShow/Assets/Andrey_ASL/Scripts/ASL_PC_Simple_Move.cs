//-------------------------------------------------------
// Simple 2D Pc Movement
// Andrey Santana, Uel, Games, 2017
//-------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASL_PC_Simple_Move : MonoBehaviour
{ 
    //---------------------------------------------------
    // Variable Definitions
    public float fl_PC_speed = 2;
    private Rigidbody2D rb_PC;
    private Vector2 v2_velocity;

    //----------------------------------------------------
	// Use this for initialization
	void Start ()
    {
        // Get a reference to the attached rigidbody
        rb_PC = GetComponent<Rigidbody2D>();
    }//-------
    
	//----------------------------------------------------
	// Update is called once per frame
	void Update ()
    {
        // Calculate the velocity vector based on player input
        v2_velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime * fl_PC_speed;

        // update the position of the PC using the velocity vector
        rb_PC.MovePosition(rb_PC.position + v2_velocity);
        
    }//----
    }//===================
