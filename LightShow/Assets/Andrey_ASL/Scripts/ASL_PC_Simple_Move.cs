
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

        
        rb_PC.MovePosition(rb_PC.position + v2_velocity);
        
    }
    }
