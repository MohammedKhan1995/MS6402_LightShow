
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASL_PC_Range_Attack : MonoBehaviour
{
    //-------------------------------------------
    // Attack Properties
    public GameObject go_projectile;
    public int in_ammo = 100;
    public bool bl_infinite_ammo = true;
    public float fl_cool_down_ = 1F;
    private float fl_next_shoot_time;
    public AudioSource audioSource;
    public AudioClip audioClip;

    //------------------------------------------
    //Update is called once per frame
    void Update()
    {
        Attack();
        
    }//------

    //----------------------------------------------------------------
    // Custom function for attack
    void Attack()
    {
        //Has the fire button (CTRL or mouse) been pressed and cooldown delay time passed
        if (Input.GetButtonDown("Fire1") && Time.time > fl_next_shoot_time)
        {
              if (bl_infinite_ammo)
             {

                // Create a bullet 1 at unit in front of the PC
                Instantiate(go_projectile, transform.position + transform.TransformDirection(Vector2.right), transform.rotation);

                audioSource.clip = audioClip;
                audioSource.Play();
            }
                         
            
                    
                
             else if (in_ammo > 0)
            {
                /// Create a bullet 1 unit in front of the PC
                Instantiate(go_projectile, transform.position + transform.TransformDirection(Vector2.right), transform.rotation);

                // Reduce Ammo
                in_ammo--;

            }
            fl_next_shoot_time = Time.time + fl_cool_down_;
        }
        // Reset cooldown time

    } //-----
}//============
