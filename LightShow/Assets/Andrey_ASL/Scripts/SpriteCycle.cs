// ----------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCycle : MonoBehaviour
{



    public Sprite[] sp_walk;
    public Sprite sp_shoot;

    public float fl_delay = 0.2F;
    private float flnextsprite;
    private int in_current_sprite;

    private SpriteRenderer sr_PC;
    private Rigidbody2D rb_PC;

    //Use this for initialization
    void Start()
    {
        rb_PC = GetComponent<Rigidbody2D>();
        sr_PC = GetComponent<SpriteRenderer>();


        // Set first Sprite
        if (sp_walk.Length > 0)
            sr_PC.sprite = sp_walk[in_current_sprite];

    }//-----

    // ----------------------------------------------------------------------
    // Update is called once per frame
    void Update()
    {
        SpriteSwap();

    }//-----


    void SpriteSwap()
    {
        // Flip on left and right pressed
        if (rb_PC.velocity.x > 0) sr_PC.flipX = false;
        if (rb_PC.velocity.x < 0) sr_PC.flipX = true;


        // While the PC is moving horizontally
        if (rb_PC.velocity.x != 0)
        {
            if (Time.time > flnextsprite)
            {
                if (in_current_sprite < sp_walk.Length - 1)
                {
                    in_current_sprite++;
                }
                else
                {
                    in_current_sprite = 0;
                }
                // Set the Sprite
                sr_PC.sprite = sp_walk[in_current_sprite];
                // Reset CoolDown
                flnextsprite = Time.time + fl_delay;
            }
        }

        // Jump sprite - moving vertically
        if (rb_PC.velocity.y != 0)
        {
            sr_PC.sprite = sp_shoot;
        }
        else
        {
            sr_PC.sprite = sp_walk[in_current_sprite];
        }

    }//-----

}//=========
