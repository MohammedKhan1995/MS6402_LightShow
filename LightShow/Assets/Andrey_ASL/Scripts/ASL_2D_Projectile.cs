
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASL_2D_Projectile : MonoBehaviour
{
    
    public float fl_speed = 5;
    public float fl_range = 10;
    public GameObject target;
    private Rigidbody2D rb_projectile;
    public string st_no_effect_tag = "Walls";

    void Start ()
    {
        // Get the reference to the rigidbody physics controller for this object
        rb_projectile = GetComponent<Rigidbody2D>();

        // Set Velocity to move fowards at the speed defined above
        rb_projectile.velocity = transform.InverseTransformDirection(Vector2.right) * fl_speed;

        void OnTriggerEnter(Collider collider) => Destroy(gameObject);


    }
	
}
