using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Walking : MonoBehaviour
{

    public float moveSpeed;

    Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            myAnimator.SetBool("Moving", true);

            this.transform.position = this.transform.position + new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyUp("left"))
        {
            myAnimator.SetBool("Moving", false);
        }

        if (Input.GetKey("right"))
        {
            myAnimator.SetBool("Moving", true);

            this.transform.position = this.transform.position + new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyUp("right"))
        {
            myAnimator.SetBool("Moving", false);
        }

        if (Input.GetKey("up"))
        {
            this.transform.position = this.transform.position + new Vector3(0, moveSpeed * Time.deltaTime, 0);
            myAnimator.SetBool("Moving", true);
        }

        if (Input.GetKeyUp("up"))
        {
            myAnimator.SetBool("Moving", false);
        }

        if (Input.GetKey("down"))
        {
            this.transform.position = this.transform.position + new Vector3(0, -moveSpeed * Time.deltaTime, 0);
            myAnimator.SetBool("Moving", true);
        }

        if (Input.GetKeyUp("down"))
        {
            myAnimator.SetBool("Moving", false);
        }

       if (Input.GetKey("space"))
        {
            //myAnimator.SetBool("Shoot", true);
            myAnimator.SetTrigger("Fire");
        }

    }
}
