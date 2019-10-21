using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASL2DNPC : MonoBehaviour
{

    // Movement  Variables
    public float fl_speed = 1; // 0 for static
    public float fl_min_move_range = 2;
    public float fl_max_move_range = 5;

    public GameObject target;



    private Rigidbody2D RB_NPC;

    //---------------------------------------------------------------------------------------
    // Use this for initialization
    void Start()
    {
        RB_NPC = GetComponent<Rigidbody2D>();
    }//-----


    void Update()
    {
        MoveNPC();

    }//-----    


    void MoveNPC()
    {
      
        Vector2 _v2_difference = target.transform.position - transform.position;
        float _fl_angle = Mathf.Atan2(_v2_difference.y, _v2_difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(_fl_angle, Vector3.forward);

        //calculate the distance to the Target (e.g PC) 
        float _fl_distance = Vector2.Distance(target.transform.position, transform.position);

        // is the target is in movement range
        if (_fl_distance < fl_max_move_range && _fl_distance > fl_min_move_range)
        {   //Move towards Target
            RB_NPC.velocity = transform.TransformDirection(Vector2.right) * fl_speed;
        }
        else
        {   // Stop Moving
            RB_NPC.velocity = Vector2.zero;
        }
    }//------  

}
